using System;
namespace FacebookOOP
{
    public class MenuController
    {
        private Step currentStep;
        public Step CurrentStep
        {
            get { return currentStep; }
            set { currentStep = value; }
        }

        public MenuController(Step step)
        {
            this.currentStep = step;
        }

        public void DisplayMessage(string message)
        {

        }

        public int DisplayMenu()
        {
            Console.Clear();
            switch (currentStep)
            {
                case Step.Startup:
                    {
                        Console.WriteLine("Facebook Manager");
                        Console.WriteLine();
                        Console.WriteLine("1. Login");
                        Console.WriteLine("2. Register");
                        Console.WriteLine("5. Exit");
                    }
                    break;
                case Step.Login:
                    {
                        Console.WriteLine("Login Manager");
                        Console.WriteLine();
                        Console.WriteLine("1. Login");
                        Console.WriteLine("2. Register");
                        Console.WriteLine("5. Exit");
                    }
                    break;
                case Step.Register:
                    break;
            }
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
    }
}
