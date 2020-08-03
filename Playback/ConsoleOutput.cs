using System;
using System.Windows.Forms;

namespace LabC
{
    public class ConsoleOutput : IOutput
    {
        public void DisplayLine(TextBox textbox, string text)
        {
            if (!string.IsNullOrWhiteSpace(text))                
            {
                textbox.AppendText(text);
            }            
        }
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
