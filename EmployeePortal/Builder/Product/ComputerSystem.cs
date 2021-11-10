using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace EmployeePortal
{
    public class ComputerSystem
    {
        public  string RAM;
        public  string HDDSize;
        public string Keyboard { get; set; }
        public string Mouse { get; set; }
        public string Touchscreen { get; set; }
        public ComputerSystem()
        {

        }
       
        //public string build()
        //{
        //    StringBuilder builder = new StringBuilder();
        //    builder.Append(string.Format("Ram :{0}", RAM));
        //    builder.Append(string.Format("HDD Size :{0}", HDDSize));
        //    return builder.ToString();

        //}
    }
}