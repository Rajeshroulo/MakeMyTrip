using System;

namespace MakeMyTrip.exception
{
    public class MakeMyTripexception : Exception
    {
        public string message;

        public enum ExceptionType
        {
            ELEMENT_NOT_FOUND,TIMED_OUT
        }
        public  ExceptionType type;

        public MakeMyTripexception(ExceptionType type,string message):base(message)
        {
            this.type = type;
            this.message = message;
        }

    }
}
