﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Factory.AbstractFactory
{
   public  interface IComputerFactory
    {
        IProcessorType Processors();
        ISystemType Systems();
        IBrand Brands();
    }
}
