using System;

class E1PrintIntegers
{
    
    static void Main ()
    {
        int sum = 0;

        Console.WriteLine ("Sum of three numbers.");

        for (int index = 0; index < 3; index++)
        {
            int var = 0; // междинна променлива
            do
            {   // Изпълнява докато се въведе число
                Console.Write ("Please enter an integer: ");
                var = enterNum (Console.ReadLine ()); 
            }while (var == 0); 

            sum += var;
        }
        Console.WriteLine ("The sum of these three numbers is: {0}", sum);
    }


    private static int enterNum (string value) // проверява дали е въведено число
    {
        int number;        
        bool result = Int32.TryParse (value, out number);
       
        if (result)
        {
            return number; // Ако е число го  връща като стойност
        }
        else
        {
            return 0; //Ако не е число връща нула
        }
    }
}
