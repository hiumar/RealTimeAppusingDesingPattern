using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory _factory;
        public EmployeeSystemManager(IComputerFactory factory)
        {
            _factory = factory;
        }
        public string GetComputerDetails()
        {
            IBrand brand = _factory.Brands();
            IProcessorType processorType = _factory.Processors();
            ISystemType systemType = _factory.Systems();
            string returnvalue = string.Format("{0} {1} {2}", brand.GetBrandName(), processorType.GetProcessorTypes(), systemType.GetSystemTyoes());
            return returnvalue;
        }
    }
}