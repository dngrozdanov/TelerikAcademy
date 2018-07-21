using System;
using System.Collections.Generic;
namespace PhoneOOP
{
    public class GSMTest
    {
        private List<GSM> phone;
        public List<GSM> Phones
        {
            get => new List<GSM>(this.phone);
            private set => this.phone = value;
        }

        public GSMTest()
        {
            GSM[] phones = new GSM[3];
            Battery[] batteries = new Battery[3];
            Display[] displays = new Display[3];

            batteries[0] = new Battery(24, 12, BatteryType.LiIon);
            batteries[1] = new Battery(12, 4, BatteryType.LiIon);
            batteries[2] = new Battery(144, 144, BatteryType.LiIon);

            displays[0] = new Display(6, 550);
            displays[1] = new Display(4.5, 125);
            displays[2] = new Display(2.5, 0);

            phones[0] = new GSM("Samsung Galaxy S8", "Samsung", "Danail", 520, batteries[0], displays[0]);
            phones[1] = new GSM("Samsung Galaxy S5", "Samsung", "Unknown", 240, batteries[1], displays[1]);
            phones[2] = new GSM("Nokia 1990's", "Nokia", "Unknown", 1000, batteries[2], displays[2]);

            phones[0].AddCall(DateTime.Now, 0884029312, 120);

            Phones = new List<GSM>();

            for (int i = 0; i < phones.Length; i++)
            {
                phone.Add(phones[i]);
            }
        }
    }
}