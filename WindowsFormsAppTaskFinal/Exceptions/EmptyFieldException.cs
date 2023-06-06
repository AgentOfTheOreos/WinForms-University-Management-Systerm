using System;

namespace WindowsFormsAppTaskFinal.Exceptions
{
    public class EmptyFieldException : Exception
    {
        public EmptyFieldException(string fieldName)
            : base($"Error, field {fieldName} is empty.")
        {
        }
    }
}