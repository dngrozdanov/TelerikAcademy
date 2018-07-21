using System;
namespace FacebookOOP
{
    public class Login
    {
        private Exceptions exceptionHandler;
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                if (value == "")
                    exceptionHandler.DisplayException(ExceptionType.EmptyField);
                else if (value.Length < 4)
                    exceptionHandler.DisplayException(ExceptionType.TooShort);
            }
        }
        public Login()
        {
            exceptionHandler = new Exceptions();
        }
    }
}
