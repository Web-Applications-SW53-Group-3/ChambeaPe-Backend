using System;

namespace _2._Domain.Exceptions
{
    public class InvalidUserIDException : Exception
    {
        public InvalidUserIDException(string msg): base($"Invalid {msg} ID")
        {
            
        }
    }
}
