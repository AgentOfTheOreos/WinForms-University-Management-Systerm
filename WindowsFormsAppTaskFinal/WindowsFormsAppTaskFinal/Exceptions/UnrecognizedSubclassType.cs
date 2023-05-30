using System;

namespace WindowsFormsAppTaskFinal.Exceptions
{
    public class UnrecognizedSubclassType : Exception
    {
        public UnrecognizedSubclassType(string message) : base(message)
        {
            
        }

    }
}