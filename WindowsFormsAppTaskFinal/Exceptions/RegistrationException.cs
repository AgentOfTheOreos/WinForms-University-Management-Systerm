using System;

namespace WindowsFormsAppTaskFinal.Exceptions
{
    public class RegistrationException : Exception
    {
        public RegistrationException(string message) : base(message)
        {
        }
    }
}