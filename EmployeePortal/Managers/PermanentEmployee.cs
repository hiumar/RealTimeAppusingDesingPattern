using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Managers
{
    public class PermanentEmployee : IEmployeeManager
    {
        public decimal GetBounus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }
    }
}