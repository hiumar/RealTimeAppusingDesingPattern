using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.Factory.AbstractFactory.Enumrations;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class Dell : IBrand
    {
        public string GetBrandName()
        {
            return Enumrations.Brands.Dell.ToString();
        }
    }
}