using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class DellFactory : IComputerFactory
    {
        public IBrand Brands()
        {
            return new Dell();
        }

        public IProcessorType Processors()
        {
            return new I5();
        }

        public  virtual ISystemType Systems()
        {
           return new DeskTop();
        }
    }
    public class DellLaptopFactory : DellFactory
    {
        public override ISystemType Systems()
        {
            return new Laptop();
        }
    }
}