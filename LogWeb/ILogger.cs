using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogWeb
{
  public   interface ILogger
    {
        void LogException(string message);
    }
}
