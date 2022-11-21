using System;

namespace ClockAngle.ClockAngleTask.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base($"Invalid input!")
        {

        }

    }
}