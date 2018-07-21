using System;
namespace PhoneOOP
{
    public class Battery
    {
        private int hoursIdle;
        private int hoursTalk;
        public BatteryType BatteryType { get; private set; }

        public int HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                try
                {
                    // Suggestions on improving this please @Steve
                    // Just use 'price = value'? But will it catch an exception
                    hoursIdle = int.Parse(value.ToString());
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException();
                }
                catch (FormatException)
                {
                    throw new FormatException();
                }
            }
        }

        public int HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                try
                {
                    // Suggestions on improving this please @Steve
                    // Just use 'price = value'? But will it catch an exception
                    hoursTalk = int.Parse(value.ToString());
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException();
                }
                catch (FormatException)
                {
                    throw new FormatException();
                }
            }
        }

        public Battery(int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string BatteryToString()
        {
            switch (this.BatteryType)
            {
                case BatteryType.LiIon:
                    return "Li-Ion";
                case BatteryType.NiMH:
                    return "NiMH";
                case BatteryType.NiCd:
                    return "NiCd";
            }
            return "No BatteryType assigned...";
        }
    }
}