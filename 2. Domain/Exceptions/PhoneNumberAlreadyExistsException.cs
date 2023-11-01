using System;

namespace _2._Domain.Exceptions
{
    public class PhoneNumberAlreadyExistsException : Exception
    {
        public PhoneNumberAlreadyExistsException() : base("The phone number is already in use") { }
    }
}
