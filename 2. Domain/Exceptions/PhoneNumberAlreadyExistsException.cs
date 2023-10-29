namespace _2._Domain.Exceptions
{
    public class PhoneNumberAlreadyExistsException : Exception
    {
        public PhoneNumberAlreadyExistsException() : base("Phone number already in use"){ }
    }
}
