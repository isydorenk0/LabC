using System.Windows.Forms;

namespace LabC
{
    public interface IOutput
    {
        void WriteLine(string test);
        void DisplayLine(TextBox textbox, string text);
    }
}
