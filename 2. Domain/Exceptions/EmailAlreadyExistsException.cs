namespace _2._Domain.Exceptions
{
    public class EmailAlreadyExistsException : Exception
    {
        public EmailAlreadyExistsException(): base("Email already in use") { }
    }
}
