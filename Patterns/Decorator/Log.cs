﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    abstract class Log
    {
        public abstract void WriteLog(string message);
    }
}
