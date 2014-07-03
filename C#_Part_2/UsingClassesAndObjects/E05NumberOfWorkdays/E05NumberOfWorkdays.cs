using System;


class E05NumberOfWorkdays
{
    static void Main ()
    {
        // Write a method that calculates the number of workdays between today and given date, passed as parameter.
        // Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
        // preliminary as array.
        
        Workdays ();
    }



    static int FilterWeekend (DateTime start, DateTime end)
    {
        if (end < start) return FilterWeekend (end, start);

        int result = 0;

        for (DateTime weekend = start; weekend <= end; weekend = weekend.AddDays (1))
        {
            if (weekend.DayOfWeek == DayOfWeek.Saturday || weekend.DayOfWeek == DayOfWeek.Sunday)
            {
                result++;
            }
        }

        return result;
    }


    static int FilterHolidays (DateTime start, DateTime end)
    {
        if (end < start) return FilterHolidays (end, start);

        int result = 0;
        DateTime[] holidays = { new DateTime(2013, 01, 01), new DateTime(2013, 03, 03), new DateTime(2013, 05, 01),
                                  new DateTime(2013, 05, 02), new DateTime(2013, 05, 03), new DateTime(2013, 05, 04),
                                  new DateTime(2013, 05, 06), new DateTime(2013, 05, 24), new DateTime(2013, 09, 06),
                                  new DateTime(2013, 09, 22), new DateTime(2013, 11, 01), new DateTime(2013, 12, 23),
                                  new DateTime(2013, 12, 24), new DateTime(2013, 12, 25), new DateTime(2013, 12, 26),
                                  new DateTime(2013, 12, 31), new DateTime(2014, 01, 01), new DateTime(2014, 03, 03),
                                  new DateTime(2013, 04, 18), new DateTime(2013, 04, 19), new DateTime(2013, 04, 20),
                                    new DateTime(2013, 05, 01), new DateTime(2013, 05, 06), new DateTime(2013, 05, 24),};

        foreach (DateTime holiday in holidays)
        {
            if (start < holiday && holiday < end &&
                !(holiday.DayOfWeek == DayOfWeek.Saturday || holiday.DayOfWeek == DayOfWeek.Sunday))
            {
                result++;
            }
        }

        return result;
    }


    static void Workdays ()
    {
        DateTime start = DateTime.Today;
        Console.WriteLine ("Today is : {0}", start);

        DateTime end = new DateTime ();

        end = EnterDate ("date you want");
        Console.WriteLine ();

        int workdays = (int) (end - start).TotalDays;

        if (workdays < 0)
        {
            workdays *= -1;
        }

        workdays += 1; // прибавя и текущият ден
        workdays -= FilterWeekend (start, end);
        workdays -= FilterHolidays (start, end);

        Console.WriteLine ("The business days in this interval are : {0}", workdays);



    }


    static DateTime EnterDate (string name) // проверява дали стойността е дата и дали е в обхвата на "DateTime"
    {                                       // ако това е изпълнено връща стойността на числото  
        DateTime date;
        bool isDate = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isDate = DateTime.TryParse (Console.ReadLine (), out date);
        } while (isDate == false);

        return date;
    }
}
