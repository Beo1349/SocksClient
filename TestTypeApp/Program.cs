using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Test.IoC;

namespace TestTypeApp
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
            Container container = new Container();
            container.RegisterSingleton<IFormOpener, FormOpener>();
            FormOpener formOpener = new FormOpener(container);
            Application.Run(new MainForm(formOpener));
        }
    }
}
