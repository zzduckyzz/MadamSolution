using System;
using System.Collections.Generic;
using System.Text;

namespace MadamSolution.Utilities.Exceptions
{
    public class MadamException : Exception
    {
        public MadamException()
        {

        }
        public MadamException(string message)
            :base(message)
        {

        }
        public MadamException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
