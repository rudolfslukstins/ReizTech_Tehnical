using System;

namespace Hierarchial_structure.Exceptions
{
    public class InvalidOperationException : Exception
    {
        public InvalidOperationException() : base("Sequence contains no elements")
        {

        }
    }
}