using System.Windows.Forms;

namespace SmartCamping
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}