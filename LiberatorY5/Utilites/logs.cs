using System;
using System.IO;

namespace LiberatorY5
{
    public class logs
    {
        public static bool isDebugEnabled = false;
        private static string LoggingTXT = "debug-logs.txt";
        public static void WriteLog(string strLog)
        {
            if (isDebugEnabled)
            {
                FileInfo logFileInfo = new FileInfo(LoggingTXT);
                DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
                if (!logDirInfo.Exists) logDirInfo.Create();
                using FileStream fileStream = new FileStream(LoggingTXT, FileMode.Append);
                using StreamWriter log = new StreamWriter(fileStream);
                log.WriteLine(DateTime.Now + " | INFO | " + strLog);
            }
        }
        public static void SpecificLog(string strLog, string logType)
        {
            if (isDebugEnabled)
            {
                FileInfo logFileInfo = new FileInfo(LoggingTXT);
                DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
                if (!logDirInfo.Exists) logDirInfo.Create();
                using FileStream fileStream = new FileStream(LoggingTXT, FileMode.Append);
                using StreamWriter log = new StreamWriter(fileStream);
                log.WriteLine(DateTime.Now + " | " + logType + " | " + strLog);
            }
        }
    }
}
