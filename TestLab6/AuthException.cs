﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestLab6
{
    public class AuthException: Exception
    {
        public AuthException()
        {

        }
        public AuthException(string message):
            base(message)
        {
        }
        public AuthException(string message, Exception inner):
            base(message, inner)
        {
        }
    }
}
