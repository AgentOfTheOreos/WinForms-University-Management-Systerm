namespace WindowsFormsAppTaskFinal.Exceptions
{
    public class InvalidCredentialsException : FormAccessException
    {
        public InvalidCredentialsException(string formName)
            : base(formName)
        {
        }

        public override string Message => "Invalid username or password.";
    }
}