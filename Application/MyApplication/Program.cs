using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //For Windows 7 and above, best to include relevant app.manifest entries as well
            //Cef.EnableHighDPISupport();

            //We're going to manually call Cef.Shutdown below, this maybe required in some complex scenarios
            //CefSharpSettings.ShutdownOnExit = false;

            //Perform dependency check to make sure all relevant resources are in our output directory.
            //Cef.Initialize(new CefSettings());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WebForm());

            //Shutdown before your application exists or it will hang.
            //Cef.Shutdown();
        }
    }
}
