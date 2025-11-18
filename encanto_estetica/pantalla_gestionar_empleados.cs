using encanto_estetica;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Encanto_Estetica
{
    public partial class pantalla_gestionar_empleados : Form
    {

        pantalla_inicio pantalla_inicio;
        string numero_empleado;

        public pantalla_gestionar_empleados(pantalla_inicio pantalla_inicio, string numero_empleado)
        {
            InitializeComponent();

            this.pantalla_inicio = pantalla_inicio;
            this.numero_empleado = numero_empleado;

            btn_actualizar_Click(btn_actualizar, null);
        }

        public void CargarEmpleados()
        {
            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string query = "SELECT " +
                                   "empleados.num_empleado AS Numero, " +
                                   "TRIM(CONCAT(empleados.nombre, ' ', empleados.apellido_paterno, ' ', empleados.apellido_materno)) AS Nombre, " +
                                   "tipos_empleado.nom_tipo_empleado AS Puesto " +
                                   "FROM empleados " +
                                   "LEFT JOIN tipos_empleado ON tipos_empleado.num_tipo_empleado = empleados.num_tipo_empleado";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());

                    DataTable empleadosTable = new DataTable();

                    adapter.Fill(empleadosTable);

                    dgv_empleados.DataSource = empleadosTable;
                }
                catch (Exception ex)
                {
                    Mensajes.Error("No se pudieron cargar los empleados. Intentar nuevamente.");

                    pantalla_inicio.Show();

                    this.Close();
                }
            }
        }

        private void btn_eliminar_empleado_Click(object sender, EventArgs e)
        {
            if (dgv_empleados.SelectedRows.Count == 0)
            {
                Mensajes.Advertencia("Selecciona un empleado para eliminar.");
                return;
            }

            string num_empleado = dgv_empleados.SelectedRows[0].Cells["Numero"].Value.ToString();
            string nombre_empleado = dgv_empleados.SelectedRows[0].Cells["Nombre"].Value.ToString();

            var result = Mensajes.Pregunta("¿Estás seguro que quieres eliminar el empleado?");

            if (result != DialogResult.Yes)
            {
                return;
            }

            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string query = "DELETE FROM empleados WHERE num_empleado = @num_empleado";

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

                    cmd.Parameters.AddWithValue("@num_empleado", num_empleado);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Mensajes.Informacion("Se eliminó al empleado " + nombre_empleado + ".");

                        btn_actualizar_Click(btn_actualizar, null);
                    }
                    else
                    {
                        Mensajes.Error("No se pudo eliminar al empleado. Intentar nuevamente.");
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error("No se pudo eliminar al empleado. Intentar nuevamente.");
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (dgv_empleados.SelectedRows.Count == 0)
            {
                Mensajes.Advertencia("Selecciona un empleado para consultar.");
                return;
            }

            string num_empleado = dgv_empleados.SelectedRows[0].Cells["Numero"].Value.ToString();

            pantalla_agregar_empleado pantalla_agregar_empleado = new pantalla_agregar_empleado(this, num_empleado, "consulta");
            pantalla_agregar_empleado.Show();

            this.Hide();
        }

        private void btn_actualizar_empleado_Click(object sender, EventArgs e)
        {
            if (dgv_empleados.SelectedRows.Count == 0)
            {
                Mensajes.Advertencia("Selecciona un empleado para actualizar.");
                return;
            }

            string num_empleado = dgv_empleados.SelectedRows[0].Cells["Numero"].Value.ToString();

            pantalla_agregar_empleado pantalla_agregar_empleado = new pantalla_agregar_empleado(this, num_empleado, "edicion");
            pantalla_agregar_empleado.Show();

            this.Hide();
        }

        private void btn_agregar_empleado_Click(object sender, EventArgs e)
        {
            pantalla_agregar_empleado pantalla_agregar_empleado = new pantalla_agregar_empleado(this, null, null);
            pantalla_agregar_empleado.Show();

            this.Hide();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            pantalla_inicio.Show();

            this.Close();
        }
    }
}
