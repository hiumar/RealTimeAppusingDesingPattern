using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.Factory.AbstractFactory.Enumrations;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class I3 : IProcessorType
    {
        public string GetProcessorTypes()
        {
            return Processor.i3.ToString();
        }
    }
    public class I5 : IProcessorType
    {
        public string GetProcessorTypes()
        {
            return Processor.i5.ToString();
        }
    }

    public class I7 : IProcessorType
    {
        public string GetProcessorTypes()
        {
            return Processor.i7.ToString();
        }
    }
}