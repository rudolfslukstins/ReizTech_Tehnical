using System;

namespace ClockAngle.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base($"Invalid input!")
        {

        }

    }
}