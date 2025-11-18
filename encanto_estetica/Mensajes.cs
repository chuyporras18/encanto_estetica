using System.Windows.Forms;

namespace encanto_estetica
{
    public static class Mensajes
    {

        public static void Advertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Informacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Pregunta(string mensaje)
        {
            return MessageBox.Show(mensaje, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
