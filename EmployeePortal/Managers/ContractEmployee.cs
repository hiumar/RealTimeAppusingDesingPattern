 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Managers
{
    public class ContractEmployee : IEmployeeManager
    {
        public decimal GetBounus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 12;
        }
       
        public decimal GetMedicalAllowance()
        {
            return 100;
        }
    }
}