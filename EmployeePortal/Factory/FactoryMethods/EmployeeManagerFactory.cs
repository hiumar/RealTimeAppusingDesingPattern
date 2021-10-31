using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.FactoryMethods
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnvalue = null;
            if (emp.EmployeeTypeId == 1)
            {
                returnvalue = new ContractEmployeeFactory(emp);
            }else if (emp.EmployeeTypeId == 2)
            {
                returnvalue = new PermanentEmployeeFactory(emp);

            }
            return returnvalue;
        }
    }
}