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
            string newui = "-newui";
            string oldui = "-oldui";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Contains(newui))
            {
                Application.Run(new NewUI());
            }
            else if (args.Contains(oldui))
            {
                Application.Run(new LiberatorY5());
            }
            else
            {
                Application.Run(new NewUI());
            }
        }
    }
}
