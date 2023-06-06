using System;
namespace WindowsFormsAppTaskFinal.Exceptions
{
    public class AllNumbersAssignedException : Exception
    {
        public AllNumbersAssignedException(string email, string phone)
            : base("All available numbers have already been assigned to the registered users" +
                   " the same role in the system. Please contact the current system administrator, details below:\n" +
                   $"Email Address: {email}\n" +
                   $"Phone Number: {phone}")
        {
            
        }

        public AllNumbersAssignedException(string message)
            : base(message)
        {
        }

        public AllNumbersAssignedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}