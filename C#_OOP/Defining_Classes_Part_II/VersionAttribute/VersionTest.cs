using System;
using System.Reflection;

namespace VersionAttribute
{

    [Version (1, 0)]
    class VersionTest
    {


        [Version (1, 5)]
        public static void TestMethod ()
        {
        }

        [Version (2, 1)]
        public enum Test { }

        [Version (2, 3)]
        public enum NestedEnum { }

        [Version (2, 5)]
        public enum NestedEnum2 { }



        [Version (1, 1)]
        static void Main ()
        {
            Type typeClass = typeof (VersionTest);

            object[] classAttribute = typeClass.GetCustomAttributes (false);

            foreach (VersionAttribute version in classAttribute)
            {
                Console.WriteLine ("\"{0}\" version is {1}", typeClass.Name, version);
            }
            Console.WriteLine ();

            Type enumTest = typeof (Test);

            object[] enumTestAttribute = enumTest.GetCustomAttributes (false);

            foreach (VersionAttribute version in enumTestAttribute)
            {
                Console.WriteLine ("\"{0}\" version is {1}", enumTest.Name, version);
            }
            Console.WriteLine ();

            MethodInfo[] infoMethods = typeClass.GetMethods (BindingFlags.Static | BindingFlags.Public);
            foreach (MethodInfo method in infoMethods)
            {
                object[] methodAttributes = method.GetCustomAttributes (false);
                Console.WriteLine ("\"{0}\" version is {1}", method.Name, (methodAttributes[0] as VersionAttribute));
            }
            Console.WriteLine ();

            Type[] enums = new Type[] { typeClass.GetNestedType ("NestedEnum"), typeClass.GetNestedType ("NestedEnum2") };
            foreach (var item in enums)
            {
                object[] nestedEnum = item.GetCustomAttributes (false);
                Console.WriteLine ("\"{0}\" version is {1}", item.Name, (nestedEnum[0] as VersionAttribute));
            }
            Console.WriteLine ();
        }
    }
}

