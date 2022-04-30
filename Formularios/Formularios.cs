using Proyeccion.Principal;
using System.Windows.Forms;

namespace Formularios
{
    internal static class FrmPresentacion
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());
        }
    }
}
