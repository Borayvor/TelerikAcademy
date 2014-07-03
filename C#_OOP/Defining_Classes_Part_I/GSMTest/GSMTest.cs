using System;
using Defining_Classes_Part_I;

namespace GSMTest
{
    class GSMTest
    {
        static void Main ()
        {
            GSM[] mobilePhone = new GSM[3];

            for (int i = 0; i < mobilePhone.Length; i++)
            {
                mobilePhone[i] = new GSM ("Lumia 720", "Nokia", 890m, "Pesho I. Petrov",
                    new Battery ("motorola", 72m, 6m, BatteryType.LiIon), new Display (8.7, "16M"));
            }

            mobilePhone[0].Owner = "Ivan P. Ivanov";
            mobilePhone[0].Battery.BatteryType = BatteryType.NiCd;
            mobilePhone[0].Display.NumberOfColors = "32M";
            mobilePhone[0].Battery.HoursIdle = 20m;

            mobilePhone[1].Price = 690.9m;
            mobilePhone[1].Battery.BatteryType = BatteryType.LiPol;
            mobilePhone[1].Display.Size = 6.4;
            mobilePhone[1].Battery.HoursTalk = 12.5m;

            mobilePhone[2] = GSM.IPhone4S;

            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < mobilePhone.Length; i++)
            {
                Console.WriteLine (mobilePhone[i]);
                Console.WriteLine ();
                Console.ForegroundColor = ConsoleColor.Green + i;
            }
        }
    }
}
