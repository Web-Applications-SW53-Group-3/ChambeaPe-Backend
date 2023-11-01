using System;

namespace _2._Domain.Exceptions
{
    public class UserRegistrationException : Exception
    {
        public UserRegistrationException() : base("An error has ocurred trying to register the account")
        {
        }
    }
}
