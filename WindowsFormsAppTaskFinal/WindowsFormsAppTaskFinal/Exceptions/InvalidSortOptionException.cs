using System;

namespace WindowsFormsAppTaskFinal.Exceptions
{
    public class InvalidSortOptionException : Exception
    {
        public InvalidSortOptionException() : base("Invalid sort option.")
        {
        }
    }
}