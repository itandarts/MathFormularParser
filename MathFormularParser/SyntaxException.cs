﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    /// <summary>
    /// exception for syntax errors
    /// </summary>
    public class SyntaxException : Exception
    {
        public SyntaxException(string message)
            : base(message)
        {
        }
    }

}
