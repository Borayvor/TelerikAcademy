namespace _01_9GagNumbers
{
    using System;
    using System.Collections.Generic;

    public class The9GagNumbers
    {      
        public static void Main(string[] args)
        {
            string[] the9Gag = new string[] { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

            string the9GagNumber = Console.ReadLine();

            List<int> decimalNumber = new List<int>();
            
            int t9GLength = 0;

            while (t9GLength < the9GagNumber.Length)
            {
                for (int index = 0; index < the9Gag.Length; index++)
                {
                    if (t9GLength + the9Gag[index].Length > the9GagNumber.Length)
                    {
                        continue;
                    }

                    string the9GagDigit = the9GagNumber.Substring(t9GLength, the9Gag[index].Length);

                    if (the9Gag[index] == the9GagDigit)
                    {
                        decimalNumber.Add(index);

                        t9GLength += the9Gag[index].Length;
                                                
                        break;
                    }
                }
            }

            ulong result = 0;

            for (int index = 0; index < decimalNumber.Count; index++)
            {
                result = result * 9 + (ulong)decimalNumber[index];
            }
           
            Console.WriteLine(result);
        }
    }
        
}
