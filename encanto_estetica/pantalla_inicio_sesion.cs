using encanto_estetica;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Encanto_Estetica
{
    public partial class pantalla_inicio_sesion : Form
    {
        public pantalla_inicio_sesion()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string num_empleado = txt_num_empleado.Text;
            string contrasena = txt_contrasena.Text;

            if (string.IsNullOrWhiteSpace(num_empleado))
            {
                Mensajes.Advertencia("El numero de empleado no puede estar vacío.");
                this.ActiveControl = txt_num_empleado;
                return;
            }

            ConexionDB db = new ConexionDB();

            try
            {
                db.OpenConnection();

                string query = "SELECT COUNT(*) FROM empleados WHERE num_empleado = @num_empleado";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@num_empleado", num_empleado);

                int numeroUsuarios = Convert.ToInt32(cmd.ExecuteScalar());

                if (numeroUsuarios == 0)
                {
                    Mensajes.Error("El numero de empleado no existe.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error("No se pudo iniciar sesión.");
                return;
            }
            finally
            {
                db.CloseConnection();
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                Mensajes.Advertencia("La contraseña no puede estar vacía.");
                this.ActiveControl = txt_contrasena;
                return;
            }

            try
            {
                db.OpenConnection();

                string query = "SELECT COUNT(*) FROM empleados WHERE num_empleado = @num_empleado AND contrasena = @contrasena";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@num_empleado", num_empleado);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                int numeroUsuarios = Convert.ToInt32(cmd.ExecuteScalar());

                if (numeroUsuarios == 0)
                {
                    Mensajes.Error("La contraseña es incorrecta.");
                    return;
                }
                else
                {
                    pantalla_inicio pantalla_inicio = new pantalla_inicio(this, num_empleado);
                    pantalla_inicio.Show();

                    this.Hide();
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void pantalla_inicio_sesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
