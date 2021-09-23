using System;
using System.Windows.Forms;

namespace EasyDeleteDirectory
{
    internal static class Program
    {
        [STAThread]
        internal static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EasyDeleteDirectoryForm());
        }
    }
}
