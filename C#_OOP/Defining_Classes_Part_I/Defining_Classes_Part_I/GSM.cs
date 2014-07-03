using System;
using System.Collections.Generic;

namespace Defining_Classes_Part_I
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;

        private List<Call> callHistory = new List<Call> ();

        public static readonly GSM IPhone4S = new GSM ("Iphone", "Apple", 1099);


        public GSM ()
            : this (null)
        {
        }

        public GSM (string model)
            : this (model, null)
        {
        }

        public GSM (string model, string manufacturer)
            : this (model, manufacturer, null)
        {
        }

        public GSM (string model, string manufacturer, decimal? price)
            : this (model, manufacturer, price, null)
        {
        }

        public GSM (string model, string manufacturer, decimal? price, string owner)
            : this (model, manufacturer, price, owner, new Battery ())
        {
        }

        public GSM (string model, string manufacturer, decimal? price, string owner, Battery battery)
            : this (model, manufacturer, price, owner, battery, new Display ())
        {
        }

        public GSM (string model, string manufacturer, decimal? price, string owner,
            Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }



        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException ("The price can't be negative !");
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {

                if (!string.IsNullOrEmpty (value) && value.Length >= 2)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentNullException ("The owner can't be empty!");
                }
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }


        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public void AddCall (string dialedNumber, uint duration)
        {
            Call addNewCall = new Call(dialedNumber, duration);
            this.callHistory.Add(addNewCall);
        }

        public void DelCall (int callNumber)
        {
            if (callNumber < this.callHistory.Count && callNumber > -1)
            {
                this.callHistory.RemoveAt(callNumber);
            }
            else
            {
                throw new ArgumentException("The duration can't be negative or out of bounds!");
            }
        }

        public void ClearCall ()
        {
            this.callHistory.Clear ();
        }

        public double TotalPriceOfTheCalls (double pricePerMinute)
        {
            uint minutes = 0;
            uint reminder = 0;

            for (int index = 0; index < this.callHistory.Count; index++)
            {
                minutes += callHistory[index].DurationSeconds / 60;

                reminder = callHistory[index].DurationSeconds % 60;

                if (reminder != 0)
                {
                    minutes++;
                }
            }

            return minutes * pricePerMinute;
        }



        public override string ToString ()
        {
            return string.Format ("# GSM #\r\nModel: {0}\r\nManufacturer: {1}\r\nPrice: {2} $\r\n" +
                "Owner: {3}\r\nBattery: {4}\r\nDisplay: {5}", this.model, this.manufacturer,
                this.price, this.owner, this.battery, this.display);
        }
    }
}
