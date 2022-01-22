using System;
using System.IO;

namespace LiberatorY5
{
    internal class logs
    {
        private static string LoggingTXT = "logging.txt";
        public static void WriteLog(string strLog)
        {
            FileInfo logFileInfo = new FileInfo(LoggingTXT);
            DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            using FileStream fileStream = new FileStream(LoggingTXT, FileMode.Append);
            using StreamWriter log = new StreamWriter(fileStream);
            log.WriteLine(DateTime.Now + " | INFO | " + strLog);
        }
        public static void SpecificLog(string strLog, string logType)
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
