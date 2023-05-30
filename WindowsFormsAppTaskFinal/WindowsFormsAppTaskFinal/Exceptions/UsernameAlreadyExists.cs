namespace WindowsFormsAppTaskFinal.Exceptions
{
    public class UsernameAlreadyExistsException : RegistrationException
    {
        public UsernameAlreadyExistsException(string message) : base(message)
        {
        }
    }
}