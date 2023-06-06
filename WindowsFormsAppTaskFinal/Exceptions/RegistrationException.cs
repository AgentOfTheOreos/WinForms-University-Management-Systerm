using System;

namespace WindowsFormsAppTaskFinal.Exceptions
{
    public class RegistrationException : Exception
    {
        protected RegistrationException(string message) : base(message)
        {
        }
    }
}