using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LogWeb
{
  
        public sealed class Log : ILogger
        {


            private Log()
            {

            }
            public static readonly Lazy<Log> instenace = new Lazy<Log>(() => new Log());

            public static Log GetInstance
            {
                get
                {



                    return instenace.Value;

                }
            }

        public void LogException(string message)
        {


            StreamWriter writer = null;
            try
            {

                string filepath = HttpContext.Current.Server.MapPath("~/App_Data/ErrorLogs/");  //Text File Path

              
                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);

                }
                filepath = filepath + "ErrorLog_" + DateTime.Today.ToString("dd-MM-yy") + ".txt";
                if (!File.Exists(filepath))
                {


                    File.Create(filepath).Dispose();

                }


                //if (File.Exists(compath))
                //    writer = info.Length < 2056192 ? info.AppendText() : info.CreateText();
                //else
                writer = File.AppendText(filepath);
                writer.WriteLine();
                writer.WriteLine("TIME_STAMP: " + DateTime.Now.ToShortDateString());

                writer.WriteLine("Error Message:");
                writer.WriteLine(message);

                writer.Close();
            }
            catch (Exception ex)
            {
                writer?.Close();
            }

            //string filename = string.Format("{0}_{1}.Log", "Exception", DateTime.Now.ToShortDateString());
            //    string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, filename);
            //    StringBuilder b = new StringBuilder();
            //    b.AppendLine("-----------------------------------");
            //    b.AppendLine(DateTime.Now.ToString());
            //    b.AppendLine(message);
            //    using (StreamWriter writer = new StreamWriter(logFilePath, true))
            //    {
            //        writer.Write(message);
            //        writer.Flush();
            //    }

            //}
        }
    }
    }

