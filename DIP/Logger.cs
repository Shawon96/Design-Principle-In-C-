using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Principle_In_CSharp.OCP
{
    public interface ILogger
    {
        void LogError(string message);
    }

    public class FileLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine("Logging Into The {0}", message);
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine("Logging Into The {0}", message);
        }
    }
}