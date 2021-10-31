using EmployeePortal.Managers;
using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.FactoryMethods
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp):base(emp)
        {

        }

      
        public override IEmployeeManager Create()
        {
            ContractEmployee manger = new ContractEmployee();
            _emp.MedicalAllowance = manger.GetMedicalAllowance();
            return manger;
        }
    }
}