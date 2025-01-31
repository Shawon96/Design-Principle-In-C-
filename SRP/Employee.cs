using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Principle_In_CSharp.SRP
{
    public class Employee
    {

        public void Save(Employee emp)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogError(ex.Message);
            }
        }
    }
}