using System;
namespace PhoneOOP
{
    public class Display
    {
        public double Size { get; private set; }
        public double NumberOfColors { get; private set; }

        public Display(double size, double numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
    }
}