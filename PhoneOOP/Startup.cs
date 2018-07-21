using System;

namespace PhoneOOP
{
    class Startup
    {
        static void Main()
        {
            Console.WriteLine(GSM.Iphone4S.ToString());

            GSMTest test = new GSMTest();
            foreach (var phone in test.Phones)
            {
                Console.WriteLine(phone.ToString());
            }
        }
    }
}