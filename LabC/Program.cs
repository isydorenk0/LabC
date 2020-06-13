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
           SimCorpMobile newPhone = new SimCorpMobile();
            string description = newPhone.GetDescription();
            
            Console.WriteLine(description);
            Console.ReadKey();
        }
    }
}
