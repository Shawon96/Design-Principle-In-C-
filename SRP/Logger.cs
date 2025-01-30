using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Principle_In_CSharp.SRP
{
    public class Logger
    {
        public void LogError(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}