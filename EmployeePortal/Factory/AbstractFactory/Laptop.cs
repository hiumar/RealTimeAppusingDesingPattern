using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.Factory.AbstractFactory.Enumrations;

namespace EmployeePortal.Factory.AbstractFactory
{
    public class Laptop : ISystemType
    {
        public string GetSystemTyoes()
        {
            return ComputerTypes.Laptop.ToString();
        }
    }
    public class DeskTop : ISystemType
    {
        public string GetSystemTyoes()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}