using Squirrel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_komunikatów_dworcowych
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            using (var mgr = new UpdateManager("C:\\Users\\Bar\\source\\repos\\Generator_komunikatow_dworcowych\\Generator_komunikatow_dworcowych\\Releases"))
            {
                await mgr.UpdateApp();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new komunikaty());
        }
    }
}
