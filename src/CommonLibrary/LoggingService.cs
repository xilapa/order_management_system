using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommonLibrary
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            using (var logFile =  File.AppendText(@"C:\log.txt"))
            {
                foreach (var item in itemsToLog)
                {
                    logFile.WriteLine(item.Log());
                }
            }
        }
    }
}