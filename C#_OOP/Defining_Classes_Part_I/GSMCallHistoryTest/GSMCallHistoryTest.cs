using System;
using System.Collections.Generic;
using Defining_Classes_Part_I;


namespace GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main ()
        {
            GSM mobilePhone = new GSM ("Lumia 720", "Nokia", null, "Pesho I. Petrov");
            double priceForMinute = 0.37;

            Console.ForegroundColor = ConsoleColor.White;
            // added calls
            mobilePhone.AddCall ("0888 888 888", 37);
            mobilePhone.AddCall ("0999 999 999", 79);
            mobilePhone.AddCall ("0111 222 222", 189);
            mobilePhone.AddCall ("0222 222 222", 163);
            mobilePhone.AddCall ("0333 333 333", 245);

            // takes history of calls
            List<Call> history = mobilePhone.CallHistory;


            // prints all calls
            for (int index = 0; index < history.Count; index++)
            {
                Console.WriteLine (history[index]);
            }

            Console.WriteLine ("The total price is: {0}", mobilePhone.TotalPriceOfTheCalls (priceForMinute));

            // remove the longest talk
            int max = 0;
            uint duration = 0;
            for (int index = 0; index < history.Count; index++)
            {
                if (history[index].DurationSeconds > duration)
                {
                    duration = history[index].DurationSeconds;
                    max = index;
                }
            }

            mobilePhone.DelCall (max);

            Console.WriteLine ("The total price without longest call is: {0}",
                                    mobilePhone.TotalPriceOfTheCalls (priceForMinute));

            mobilePhone.ClearCall ();

            // prints all calls to show that history is empty
            for (int index = 0; index < history.Count; index++)
            {
                Console.WriteLine (history[index]);
            }
        }
    }
}
