using System;

namespace _2._Domain.Exceptions;

public class InvalidWorkerIDException: Exception
{
    public InvalidWorkerIDException(string msg): base($"Invalid {msg} ID")
    {
            
    }
}