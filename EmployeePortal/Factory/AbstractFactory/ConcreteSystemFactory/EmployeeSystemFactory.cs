using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.Factory.AbstractFactory.MacFactory;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee employee)
        {
            IComputerFactory returnvalue = null;
            if (employee.EmployeeTypeId == 2)
            {
                if (employee.JobDescription == "Manager")
                {
                    returnvalue = new MacFactory();
                }else
                {
                    returnvalue = new MacLapTopFactory();
                }
            }else if (employee.EmployeeTypeId == 1)
            {
                if (employee.JobDescription == "Manager")
                {
                    returnvalue = new DellLaptopFactory();
                }else
                {
                    returnvalue = new DellFactory();
                }
            }
            return returnvalue;
        }
    }
}