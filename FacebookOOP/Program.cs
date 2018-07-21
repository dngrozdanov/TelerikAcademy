using System;

namespace FacebookOOP
{
    class Startup
    {
        static void Main()
        {
            Step CurrentStep = Step.Startup;
            MenuController menu = new MenuController(CurrentStep);
            int userInput = 0;
            do
            {
                // Update CurrentStep
            } while (userInput != 5);
        }
    }
}
