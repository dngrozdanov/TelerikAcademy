using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace PhoneOOP
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private string owner;
        private int price;

        public string Model
        {
            get { return model; }
            set
            {
                if (value == "")
                    throw new ArgumentNullException();
                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value == "")
                    throw new ArgumentException();
                manufacturer = value;
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (value == "")
                    owner = "Unknown";
                else
                    owner = value;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                try
                {
                    // Suggestions on improving this please @Steve
                    // Just use 'price = value'? But will it catch an exception
                    price = int.Parse(value.ToString());
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

        public Battery GetBattery { get; }
        public Display GetDisplay { get; }
        public List<Call> CallHistory { get; private set; }

        public static GSM Iphone4S = new GSM("iPhone 4S", "Apple Inc.", "Daniel", 440, new Battery(24, 12, BatteryType.LiIon), new Display(4, 4));

        public GSM(string model, string manufacturer, string owner = "Unknown", int price = 0)
        {
            if (model != null && manufacturer != null)
            {
                this.Model = model;
                this.Manufacturer = manufacturer;
                this.Owner = owner;
                this.price = price;
                this.CallHistory = new List<Call>();
            }
            else
            {
                Console.WriteLine("Model and Manufacturer cannot be empty fields...");
            }
        }

        public GSM(string model, string manufacturer, string owner = "Unknown", int price = 0, Battery battery = null) : this(model, manufacturer, owner, price)
        {
            if (battery != null)
            {
                this.GetBattery = battery;
            }
            else
            {
                Console.WriteLine("Model and Manufacturer cannot be empty fields...");
            }
        }

        public GSM(string model, string manufacturer, string owner = "Unknown", int price = 0, Battery battery = null, Display display = null) : this(model, manufacturer, owner, price, battery)
        {
            if (display != null)
            {
                this.GetDisplay = display;
            }
            else
            {
                Console.WriteLine("Model and Manufacturer cannot be empty fields...");
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            if (Model == "" || Manufacturer == "") return "No Phone Information";
            builder.AppendLine($"Model: {this.Model}");
            builder.AppendLine($"Manufacturer: {this.Manufacturer}");
            builder.AppendLine($"Owner: {this.Owner}");
            builder.AppendLine($"Price: ${this.Price}");
            if (this.GetBattery != null)
            {
                builder.AppendLine($"Battery: {this.GetBattery.BatteryToString()}");
                builder.AppendLine($"Hours of Idle: {this.GetBattery.HoursIdle} Hours");
                builder.AppendLine($"Hours of Talk: {this.GetBattery.HoursTalk} Hours");
            }
            if (this.GetDisplay != null)
            {
                builder.AppendLine($"Display Size (edge to edge): {this.GetDisplay.Size} inches");
                builder.AppendLine($"Number Of Colors: {this.GetDisplay.NumberOfColors} million");
            }
            if (this.CallHistory != null)
            {
                builder.AppendLine($"Total Calls Cost: ${this.CalculateCallPrice()}");
            }
            return builder.ToString();
        }

        /// <summary>
        /// Adds the call to the CallHistory Collection.
        /// </summary>
        /// <param name="date">Date And Time</param>
        /// <param name="number">Phone Number</param>
        /// <param name="duration">Call Duration</param>
        public void AddCall(DateTime date, int number, int duration)
        {
            CallHistory.Add(new Call(date, number, duration));
        }

        #region CallHistory Methods
        /// <summary>
        /// Deletes the longest call.
        /// </summary>
        public void DeleteCallLongest()
        {
            CallHistory.Remove(CallHistory.FirstOrDefault(x => x.Duration == CallHistory.Max().Duration));
        }

        /// <summary>
        /// Deletes All Calls that match the given number.
        /// </summary>
        /// <param name="number">Phone Number</param>
        public void DeleteCallAll(int number)
        {
            foreach (var call in CallHistory.Where(x => x.PhoneNumber == number))
            {
                CallHistory.Remove(call);
            }
        }

        /// <summary>
        /// Deletes the first call that matches the given number.
        /// </summary>
        /// <param name="number">Phone Number</param>
        public void DeleteCall(int number)
        {
            CallHistory.Remove(CallHistory.FirstOrDefault(x => x.PhoneNumber == number));
        }

        public double CalculateCallPrice(double priceperminute = 0.37)
        {
            double TotalDuration = 0;
            foreach (var call in CallHistory)
            {
                TotalDuration += call.Duration;
            }
            return (TotalDuration / 60) * priceperminute;
        }
        #endregion
    }
}