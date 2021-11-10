using EmployeePortal.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace EmployeePortal.Builder.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem(ISystemBuilder systemBuilder,NameValueCollection collection)
        {
            systemBuilder.AddDrive(collection["HDDSize"]);
            systemBuilder.AddMemory(collection["RAM"]);
            systemBuilder.AddKayboard(collection["Keyboard"]);
            systemBuilder.AddMouse(collection["Mouse"]);
            systemBuilder.AddTouchScreen(collection["Touchscreen"]);
        }
    }
}