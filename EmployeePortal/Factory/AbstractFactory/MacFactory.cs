using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class MacFactory : IComputerFactory
    {
        public IBrand Brands()
        {
            return new Mac();
        }

        public IProcessorType Processors()
        {
            return new I7();
        }

        public  virtual ISystemType Systems()
        {
            return new DeskTop();
        }
        public class MacLapTopFactory : MacFactory
        {
         

            public  override ISystemType Systems()
            {
                return new Laptop();
            }
        }
    }
}