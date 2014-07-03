using System;

class E03WhichDayIsToday
{
    static void Main ()
    {
        // Write a program that prints to the console which day of the week is today. Use System.DateTime.
        DateTime day = DateTime.Today;

        Console.WriteLine ("Today is {0}.", day.DayOfWeek);
    }
}
