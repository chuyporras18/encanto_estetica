using System;
using System.Windows.Forms;

namespace Encanto_Estetica
{
    public partial class pantalla_inicio : Form
    {

        pantalla_inicio_sesion pantalla_inicio_sesion;
        string numero_empleado;

        public pantalla_inicio(pantalla_inicio_sesion pantalla_inicio_sesion, string num_empleado)
        {
            InitializeComponent();

            this.pantalla_inicio_sesion = pantalla_inicio_sesion;
            this.numero_empleado = num_empleado;
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            pantalla_gestionar_empleados pantalla_gestionar_empleados = new pantalla_gestionar_empleados(this, numero_empleado);
            pantalla_gestionar_empleados.Show();

            this.Hide();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            pantalla_inicio_sesion.Show();

            this.Close();
        }

        private void btn_citas_Click(object sender, EventArgs e)
        {
            pantalla_gestionar_citas pantalla_gestionar_citas = new pantalla_gestionar_citas(this, numero_empleado);
            pantalla_gestionar_citas.Show();
            this.Hide();
        }
    }
}
