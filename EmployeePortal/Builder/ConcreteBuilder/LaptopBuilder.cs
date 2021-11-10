using EmployeePortal.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Builder.ConcreteBuilder
{
    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptop = new ComputerSystem();
        public void AddDrive(string size)
        {
            laptop.HDDSize = size;
        }

        public void AddKayboard(string type)
        {
            laptop.Keyboard = type;
        }

        public void AddMemory(string memory)
        {
            laptop.RAM = memory;
        }

        public void AddMouse(string type)
        {
            laptop.Mouse = type;
        }

        public void AddTouchScreen(string enabled)
        {
            return;
        }

        public ComputerSystem GetSystem()
        {
            return laptop;
        }
    }
}