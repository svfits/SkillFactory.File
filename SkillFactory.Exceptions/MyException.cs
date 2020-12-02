using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Exceptions
{
    public class MyException : Exception
    {
        public MyException()
        { }

        public MyException(string message) : base(message)
        { }
    }
}
