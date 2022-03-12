using System.IO;
using System.Net;

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
        public static string Version = "DEV-20220311.0";
#else
        public static string Version = "20220311.0";
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
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
