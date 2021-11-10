using EmployeePortal.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Builder.ConcreteBuilder
{
    public class DesktopBuilder : ISystemBuilder
    {
        ComputerSystem desktop = new ComputerSystem();
        public void AddDrive(string size)
        {
            desktop.HDDSize = size;
        }

        public void AddKayboard(string type)
        {
            desktop.Keyboard = type;
        }

        public void AddMemory(string memory)
        {
            desktop.RAM = memory;
        }

        public void AddMouse(string type)
        {
            desktop.Mouse = type;
        }

        public void AddTouchScreen(string enabled)
        {
            desktop.Touchscreen = enabled;
        }

        public ComputerSystem GetSystem()
        {
            return desktop;
        }
    }
}