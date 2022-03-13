using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberatorY5
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string isdebug = "-debug";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Contains(isdebug))
            {
                logs.isDebugEnabled = true;
            }
            logs.WriteLog("Liberator Reloaded is Started!");
            bool versionCheck =  Stuff.VersionCheck();
            if (!versionCheck)
            {
                Stuff.StartUpdate();
            }
            Application.Run(new NewUI());
            logs.WriteLog("Liberator Reloaded is Exited!");

        }
    }
}
