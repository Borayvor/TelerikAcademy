using System;

namespace Defining_Classes_Part_I
{
    public enum BatteryType { LiPol, LiIon, NiMH, NiCd };

    public class Battery
    {
        private string model;
        private decimal? hoursIdle;
        private decimal? hoursTalk;
        private BatteryType batteryType;

        public Battery ()
            : this (null)
        {
        }

        public Battery (string model)
            : this (model, null)
        {
        }

        public Battery (string model, decimal? hoursIdle)
            : this (model, hoursIdle, null)
        {
        }

        public Battery (string model, decimal? hoursIdle, decimal? hoursTalk)
            : this (model, hoursIdle, hoursTalk, BatteryType.LiIon)
        {
        }

        public Battery (string model, decimal? hoursIdle, decimal? hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public decimal? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value > 1)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException ("The idle hours should be a positive number !");
                }
            }
        }

        public decimal? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value > 1)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException ("The idle hours should be a positive number !");
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }


        public override string ToString ()
        {
            return string.Format ("\r\n\tModel: {0}\r\n\tHours Idle: {1}\r\n\tHours Talk: {2}" +
                "\r\n\tBattery Type: {3}", this.model, this.hoursIdle, this.hoursTalk, this.batteryType);
        }
    }
}
