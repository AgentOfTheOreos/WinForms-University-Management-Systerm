namespace WindowsFormsAppTaskFinal.Exceptions
{
    public class IdAlreadyExistsException : RegistrationException
    {
        public IdAlreadyExistsException(string message) : base(message)
        {
        }
    }
}