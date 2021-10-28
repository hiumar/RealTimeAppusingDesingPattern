using System;
using System.IO;
using System.Text;

namespace Logger
{
    public sealed class Log:ILogger
    {


        public Log()
        {

        }
        private readonly static Lazy<Log> instenace = new Lazy<Log>(()=>new Log());

        public static Log GetInstance
        {
            get
            {



                return instenace.Value;

            }
        }

        public void LogException(string message)
        {
            string filename = string.Format("{0}_{1}.Log", "Exception", DateTime.Now.ToShortDateString());
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, filename);
            StringBuilder b = new StringBuilder();
            b.AppendLine("-----------------------------------");
            b.AppendLine(DateTime.Now.ToString());
            b.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath,true))
            {
                writer.Write(message);
                writer.Flush();
            }

        }
    }
}

