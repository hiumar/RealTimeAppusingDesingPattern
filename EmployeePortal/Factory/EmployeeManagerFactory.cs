using EmployeePortal.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeId)
        {
            IEmployeeManager returnvalue = null;
            if (employeeTypeId == 1)
            {
                returnvalue = new ContractEmployee();
                
            }else if (employeeTypeId == 2)
            {
                returnvalue = new PermanentEmployee();
            }
            return returnvalue;
        }
    }
}