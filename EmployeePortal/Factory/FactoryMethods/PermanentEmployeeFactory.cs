using EmployeePortal.Managers;
using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.FactoryMethods
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
      
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {

        }
        public override IEmployeeManager Create()
        {
            PermanentEmployee manger = new PermanentEmployee();
            _emp.HouseAllowance = manger.GetHouseAllowance();
            return manger;
        }
    }
}