using System;
namespace FacebookOOP
{
    public enum ExceptionType
    {
        EmptyField,
        InvalidFormat,
        TooShort
    }

    public class Exceptions
    {
        public void DisplayException(ExceptionType ex)
        {
            Console.Clear();
            switch (ex)
            {
                case ExceptionType.EmptyField:
                    Console.WriteLine("One of the fields was empty. Try again...");
                    break;
                case ExceptionType.InvalidFormat:
                    Console.WriteLine("One of the fields had invalid input. Try again...");
                    break;
                case ExceptionType.TooShort:
                    Console.WriteLine("One of the fields had too short input. Try again...");
                    break;
            }
        }
    }
}
