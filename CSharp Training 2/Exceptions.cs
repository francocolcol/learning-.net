using System;

namespace CSharp_Training_2
{
    public class MyStackUnderFlowException : Exception
    {
        public MyStackUnderFlowException()
        {
        }

        public MyStackUnderFlowException(string message)
            : base(message)
        {
        }

        public MyStackUnderFlowException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class MyStackOverflowException : Exception
    {
        public MyStackOverflowException()
        {
        }

        public MyStackOverflowException(string message)
            : base(message)
        {
        }

        public MyStackOverflowException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
