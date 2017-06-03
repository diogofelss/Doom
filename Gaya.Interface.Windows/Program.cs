using Gaya.Interface.Windows.Views;
using Gaya.Interface.Windows.Views.LogOn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaya.Interface.Windows
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

            var areaclient = new FrmClientArea();

            Globals.Mensagens = new FrameWork.StatusBarManager(areaclient.textStatusBar, areaclient.progressBar1);
            Globals.TratamentoErro = new FrameWork.ExceptionTratament();

            Application.Run(areaclient);
        }
    }
}
