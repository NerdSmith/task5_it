using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace task6_it
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new Application());
        }
    }
}