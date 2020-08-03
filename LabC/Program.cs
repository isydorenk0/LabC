using LabC;
using System;
using static Common.GetPlayableType;
using static Common.GetPlayback;
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
            ScdMobilePhone newPhone = new ScdMobilePhone();
            Console.WriteLine(newPhone);

            HeadSetTypes headSetType = GetHeadSetType();
            if (headSetType != 0)
            {
                var outputstring = $"{headSetType.ToString()} playback selected\nSet playback to Mobile...\nPlay sound in Mobile:";
                Console.WriteLine(outputstring);
                IPlayback headSetPlay = GetPlaybackType(headSetType);
                headSetPlay.Play();
            }
            else
            {
                Environment.Exit(0);
            }

            Console.WriteLine("\nLaunching Window...");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShowPlaybackForm());
        }
    }
}
