using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinChitare
{
    public enum Wood
    {
        Stejar = 1,
        Brad = 2,
        Molid = 3
    }
    public enum Builder
    {
        Romchitara = 1,
        Chitaro =2,
        MelodiaSA = 3
    }
    public enum Type
    {
        Electrica = 1,
        Acustica = 2,
        PeAburi = 3
    }
    static partial class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
