using System;

namespace PassKeeper.Exceptions
{
    public class PassException : Exception
    {
        public String Caption { get; private set; }

        public PassException(String message)
            : this("(╯°□°)╯︵ ┻━┻)", message)
        { }

        public PassException(String caption, String message)
            : this(caption, message, null)
        { }

        public PassException(String caption, String message, Exception innerException) :
            base(message, innerException)
        {
            this.Caption = caption;
        }
    }
}