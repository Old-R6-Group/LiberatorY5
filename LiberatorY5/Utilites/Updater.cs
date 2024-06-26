﻿using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;

namespace LiberatorY5
{
    public class Stuff
    {
        public static void Update_Download()
        {
            try
            {
                if (File.Exists("Update\\LiberatorY5.exe"))
                {
                    File.Delete("Update\\LiberatorY5.exe");
                }
            }
            finally
            {
                if (!File.Exists("Update\\LiberatorY5.exe"))
                {
                    //Download
                    string Download = "https://github.com/SlejmUr/Versions/raw/main/LiberatorY5.exe";
                    string filename = "LiberatorY5_Update.exe";
                    WebClient myWebClient = new WebClient();
                    myWebClient.DownloadFile(Download, filename);
                    if (!Directory.Exists("Update")) { Directory.CreateDirectory("Update"); }
                    File.Move(filename, "Update\\LiberatorY5.exe");
                }
            }
        }
        public static void Batch_Download()
        {
            if (!File.Exists("update.bat"))
            {
                //Download
                string Download = "https://github.com/SlejmUr/Versions/raw/main/update.bat";
                string filename = "update.bat";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(Download, filename);
            }
        }
        public static string GetVersion()
        {
            string version = "https://raw.githubusercontent.com/SlejmUr/Versions/main/liby5";
            try
            {
                WebClient webclient = new WebClient();
                Stream stream = webclient.OpenRead(version);
                StreamReader reader = new StreamReader(stream);
                string content = reader.ReadLine();
                return content;

            }
            catch (WebException copyError)
            {
                logs.WriteLog(copyError.Message);
            }
            return Version;
        }
#if DEBUG
        public static string Version = "DEV-Version";
#else
        public static string Version = "20220513.0";
#endif
        public static bool VersionCheck() //give back true is version is good, give back false if not
        {
            string tmpVersion = Version;
            string webVersion = GetVersion();
            if (tmpVersion.StartsWith("DEV-"))
            {
                logs.SpecificLog("DEV version! No support, only for testing", "Loading/Starting");
                return true;
            }
            else
            {
                if (tmpVersion != webVersion)
                {
                    logs.SpecificLog("Version Missmatch! [Tool Version:" + tmpVersion + " , Web Version: " + webVersion + " ]", "Loading/Starting");
                    Update_Download();
                    Batch_Download();
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static void StartUpdate()
        {
            string StartArgName = "/C update.bat ";
            //  Start downloading
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = StartArgName;
            process.Start();

        }
    }
}
