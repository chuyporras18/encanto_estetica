using encanto_estetica;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Encanto_Estetica
{
    public partial class pantalla_gestionar_citas : Form
    {

        pantalla_inicio pantalla_inicio;
        string numero_empleado;

        public pantalla_gestionar_citas(pantalla_inicio pantalla_inicio, string numero_empleado)
        {
            InitializeComponent();

            this.pantalla_inicio = pantalla_inicio;
            this.numero_empleado = numero_empleado;

            CargarEmpleado();

            btn_actualizar_Click(btn_actualizar, null);
        }

        private void CargarEmpleado()
        {
            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string query = "SELECT TRIM(CONCAT(nombre, ' ', apellido_paterno, ' ', apellido_materno)) AS Nombre " +
                                   "FROM empleados " +
                                   "WHERE num_empleado = @num_empleado";

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@num_empleado", numero_empleado);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lbl_usuario.Text = "Empleado: " + reader["Nombre"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Mensajes.Error("Error al cargar el empleado.");
                    this.Close();
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        public void CargarCitas()
        {
            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string query = "SELECT citas.num_cita AS Cita, TRIM(CONCAT(citas.nombre, ' ', citas.apellido_paterno, ' ', citas.apellido_materno)) AS Nombre, " +
                                   "tipo_servicios.nom_servicio AS Servicio, fecha_servicio AS Fecha " +
                                   "FROM citas " +
                                   "LEFT JOIN tipo_servicios ON tipo_servicios.num_tipo_servicio = citas.num_tipo_servicio " +
                                   "WHERE citas.num_empleado = @num_empleado";

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@num_empleado", numero_empleado);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable citasTable = new DataTable();

                    adapter.Fill(citasTable);

                    dgv_citas.DataSource = citasTable;
                }
                catch (Exception ex)
                {
                    Mensajes.Error("No se pudieron cargar las citas. Intentar nuevamente.");

                    pantalla_inicio.Show();

                    this.Close();
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void btn_eliminar_cita_Click(object sender, EventArgs e)
        {
            if (dgv_citas.SelectedRows.Count == 0)
            {
                Mensajes.Advertencia("Seleccione una cita para eliminar.");
                return;
            }

            string numero_cita = dgv_citas.SelectedRows[0].Cells["Cita"].Value.ToString();

            var result = Mensajes.Pregunta("¿Estás seguro que quieres eliminar la cita agendada?");

            if (result != DialogResult.Yes)
            {
                return;
            }

            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string query = "DELETE FROM citas WHERE num_empleado = @num_empleado AND num_cita = @num_cita";

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

                    cmd.Parameters.AddWithValue("@num_empleado", numero_empleado);
                    cmd.Parameters.AddWithValue("@num_cita", numero_cita);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Mensajes.Informacion("Cita eliminada correctamente.");
                        CargarCitas();
                    }
                    else
                    {
                        Mensajes.Error("No se pudo eliminar la cita. Intente nuevamente.");
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error("Error al eliminar la cita. Intente nuevamente.");
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (dgv_citas.SelectedRows.Count == 0)
            {
                Mensajes.Advertencia("Seleccione una cita para consultar.");
                return;
            }

            string numero_cita = dgv_citas.SelectedRows[0].Cells["Cita"].Value.ToString();

            pantalla_agregar_cita pantalla_Agregar_Cita = new pantalla_agregar_cita(this, numero_empleado, numero_cita, "consultar");
            pantalla_Agregar_Cita.Show();

            this.Hide();
        }

        private void btn_actualizar_cita_Click(object sender, EventArgs e)
        {
            if (dgv_citas.SelectedRows.Count == 0)
            {
                Mensajes.Advertencia("Seleccione una cita para actualizar.");
                return;
            }

            string numero_cita = dgv_citas.SelectedRows[0].Cells["Cita"].Value.ToString();

            pantalla_agregar_cita pantalla_Agregar_Cita = new pantalla_agregar_cita(this, numero_empleado, numero_cita, "edicion");
            pantalla_Agregar_Cita.Show();

            this.Hide();
        }

        private void btn_agregar_cita_Click(object sender, EventArgs e)
        {
            pantalla_agregar_cita pantalla_Agregar_Cita = new pantalla_agregar_cita(this, numero_empleado, null, null);
            pantalla_Agregar_Cita.Show();

            this.Hide();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            pantalla_inicio.Show();

            this.Close();
        }
    }
}
