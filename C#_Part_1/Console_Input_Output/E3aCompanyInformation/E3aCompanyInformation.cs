using System;

class E3aCompanyInformation
{
    static void Main ()
    {        
        Console.WriteLine ("Please, enter information for the company :");
        Console.Write ("Name of the company : ");
        string companyName = Console.ReadLine ();

        Console.Write ("Adress of the company : ");
        string companyAdress = Console.ReadLine ();

        Console.Write ("Phone number of the company : ");
        ulong companyPhone = enterNum (Console.ReadLine ());

        Console.Write ("Fax number of the company : ");
        ulong companyFax = enterNum (Console.ReadLine ());

        Console.Write ("Web site of the company : ");
        string companyWeb = Console.ReadLine ();

        Console.WriteLine ("Please, enter information for manager of the company : ");
        Console.Write ("First name : ");
        string managerFirstName = Console.ReadLine ();

        Console.Write ("Last name : ");
        string managerLastName = Console.ReadLine ();

        Console.Write ("Age : ");
        byte managerAge = enterAge (Console.ReadLine ());

        Console.Write ("Phone number : ");
        ulong managerPhone = enterNum (Console.ReadLine ());

        Console.WriteLine ("\n");

        Console.WriteLine ("Information for the company :");
        Console.WriteLine ("Name of the company : {0}", companyName);
        Console.WriteLine ("Adress of the company : {0}", companyAdress);
        Console.WriteLine ("Phone number of the company : {0}", companyPhone);
        Console.WriteLine ("Fax number of the company : {0}", companyFax);
        Console.WriteLine ("Web site of the company : {0}", companyWeb);

        Console.WriteLine ("Information for manager of the company : ");
        Console.WriteLine ("First name : {0}", managerFirstName);
        Console.WriteLine ("Last name : {0}", managerLastName);       
        Console.WriteLine ("Age : {0}", managerAge);       
        Console.WriteLine ("Phone number : {0}", managerPhone);        
    }


    private static ulong enterNum (string value) // проверява дали е въведено число
    {
        ulong number = 0;
        bool result = ulong.TryParse (value, out number);

        if (result)
        {
            return number; // Ако е число го  връща като стойност
        }
        else
        {
            return 0; //Ако не е число връща 0
        }
    }

    private static byte enterAge (string value) // проверява дали е въведено число
    {
        byte number = 0;
        bool result = byte.TryParse (value, out number);

        if (result)
        {
            return number; // Ако е число го  връща като стойност
        }
        else
        {
            return 0; //Ако не е число връща 0
        }
    }
}
