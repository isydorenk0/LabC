using System;
using System.Windows.Forms;

namespace LabC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());

            MobilePhone mobile = new MobilePhone();
            mobile.Display.Pixels.Horizontal = 596;
            mobile.Display.Type = "OLED";
            mobile.Body.Color = "Blue";
            mobile.Battery.Builtin = true;
            mobile.Simcard.SimType = "ddd";
            mobile.Simcard.ESim = false;
        }
    }
}
