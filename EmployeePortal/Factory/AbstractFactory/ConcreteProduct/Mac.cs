using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.Factory.AbstractFactory.Enumrations;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class Mac : IBrand
    {
        public string GetBrandName()
        {
            return Brands.Apple.ToString();
        }
    }
}