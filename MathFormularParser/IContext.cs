﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormularParser
{
    /// <summary>
    /// 
    /// </summary>
    public interface IContext
    {
        double ResolveVariable(string name);
        double CallFunction(string name, double[] arguments);
    }
}
