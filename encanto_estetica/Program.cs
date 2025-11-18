using System;
using System.Windows.Forms;

namespace Encanto_Estetica
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new pantalla_inicio_sesion());
        }
    }
}
