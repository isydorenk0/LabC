using System;
using System.Windows.Forms;
using static LabC.MobilePhone;

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
            ScdMobilePhone newPhone = new ScdMobilePhone();            
            Console.WriteLine(newPhone);
            Console.ReadKey();
        }
    }
}
