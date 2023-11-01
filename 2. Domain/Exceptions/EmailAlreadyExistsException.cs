using System;

namespace _2._Domain.Exceptions
{
    public class EmailAlreadyExistsException : Exception
    {
        public EmailAlreadyExistsException(): base("The email is already in use") { }
    }
}
