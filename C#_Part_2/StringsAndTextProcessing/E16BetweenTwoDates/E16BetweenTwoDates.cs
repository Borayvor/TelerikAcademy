using System;
using System.Globalization;

class E16BetweenTwoDates
{
    static void Main ()
    {
        // Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
        Console.WriteLine ("dd.MM.yyyy");
        DateTime startDate = GetDate ("start date");

        DateTime endDate = GetDate ("end date");

        Console.WriteLine ("Result is : {0} day/s", (endDate - startDate).TotalDays);
    }


    static DateTime GetDate (string name) // проверява дали стойността е дата и дали е в обхвата на "DateTime"
    {                                     // ако това е изпълнено връща стойността на числото  
        DateTime date;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isNumber = DateTime.TryParseExact (Console.ReadLine (), "dd.MM.yyyy", 
                                                CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
        } while (isNumber == false);
                
        return date;
    }
}
