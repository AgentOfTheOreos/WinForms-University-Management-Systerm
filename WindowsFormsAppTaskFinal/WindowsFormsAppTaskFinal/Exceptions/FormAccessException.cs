using System;

namespace WindowsFormsAppTaskFinal.Exceptions
{
    public abstract class FormAccessException : Exception
    {
        protected FormAccessException(string formName)
            : base($"Error attempting to access {formName}")
        {
        }
    }
}