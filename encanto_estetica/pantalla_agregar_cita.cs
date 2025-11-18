using encanto_estetica;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace Encanto_Estetica
{
    public partial class pantalla_agregar_cita : Form
    {

        pantalla_gestionar_citas pantalla_gestionar_citas;
        private string num_empleado;
        private string num_cita;
        private string operacion;

        public pantalla_agregar_cita(pantalla_gestionar_citas pantalla_gestionar_citas, string num_empeleado, string num_cita, string operacion)
        {
            InitializeComponent();

            this.pantalla_gestionar_citas = pantalla_gestionar_citas;
            this.num_empleado = num_empeleado;
            this.num_cita = num_cita;
            this.operacion = operacion;

            if (operacion == null)
            {
                this.Text = "Agendar Cita";
            }
            else if (operacion == "consultar")
            {
                this.Text = "Consultar Cita";
            }
            else if (operacion == "editar")
            {
                this.Text = "Modificar Cita";
            }

            lbl_encabezado.Text = this.Text;

            CargarServicios();

            if (num_cita != null)
            {
                CargarInformacionCita();
            }
        }

        private void CargarInformacionCita()
        {
            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string query = "SELECT num_tipo_servicio, nombre, apellido_paterno, apellido_materno, fecha_servicio " +
                                   "FROM citas WHERE num_empleado = @num_empleado AND num_cita = @num_cita";

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@num_empleado", num_empleado);
                    cmd.Parameters.AddWithValue("@num_cita", num_cita);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_nombre.Text = reader["nombre"].ToString();
                        txt_apellido_paterno.Text = reader["apellido_paterno"].ToString();
                        txt_apellido_materno.Text = reader["apellido_materno"].ToString();

                        dtp_fecha_cita.Value = Convert.ToDateTime(reader["fecha_servicio"]);

                        int num_tipo_servicio = Convert.ToInt32(reader["num_tipo_servicio"]);

                        for (int i = 1; i < cb_servicios.Items.Count; i++)
                        {
                            string item = cb_servicios.Items[i].ToString();
                            int item_num_tipo_servicio = int.Parse(item.Split(':')[0]);

                            if (item_num_tipo_servicio == num_tipo_servicio)
                            {
                                cb_servicios.SelectedIndex = i;
                                break;
                            }
                        }

                        if (operacion == "consultar")
                        {
                            btn_agregar.Visible = false;
                            txt_nombre.Enabled = false;
                            txt_apellido_paterno.Enabled = false;
                            txt_apellido_materno.Enabled = false;
                            dtp_fecha_cita.Enabled = false;
                            cb_servicios.Enabled = false;
                        }

                        if (operacion == "edicion")
                        {
                            btn_agregar.Text = "Guardar Cambios";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error("No se pudo cargar la información de la cita. Intentar nuevamente.");

                    pantalla_gestionar_citas.Show();

                    this.Close();
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void CargarServicios()
        {
            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string query = "SELECT CONCAT(num_tipo_servicio, ': ', nom_servicio) AS Servicio FROM tipo_servicios";

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

                    MySqlDataReader reader = cmd.ExecuteReader();

                    cb_servicios.Items.Clear();
                    cb_servicios.Items.Add("-- Seleccionar Servicio --");

                    while (reader.Read())
                    {
                        cb_servicios.Items.Add(reader["Servicio"].ToString());
                    }

                    cb_servicios.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    Mensajes.Error("No se pudieron cargar los servicios. Intentar nuevamente.");

                    pantalla_gestionar_citas.Show();

                    this.Close();
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private async void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cb_servicios.SelectedIndex == 0)
            {
                Mensajes.Advertencia("Debe de seleccionar un servicio para la cita.");
                this.ActiveControl = cb_servicios;
                return;
            }

            int num_tipo_servicio = int.Parse(cb_servicios.SelectedItem.ToString().Split(':')[0]);

            string nombre = txt_nombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Mensajes.Advertencia("El nombre del cliente no puede estar vacío.");
                this.ActiveControl = txt_nombre;
                return;
            }

            string apellido_paterno = txt_apellido_paterno.Text.Trim();

            if (string.IsNullOrWhiteSpace(apellido_paterno))
            {
                Mensajes.Advertencia("El apellido paterno del cliente no puede estar vacío.");
                this.ActiveControl = txt_apellido_paterno;
                return;
            }

            string apellido_materno = txt_apellido_materno.Text.Trim();

            if (string.IsNullOrWhiteSpace(apellido_materno))
            {
                Mensajes.Advertencia("El apellido materno del cliente no puede estar vacío.");
                this.ActiveControl = txt_apellido_materno;
                return;
            }

            DateTime fecha_servicio = dtp_fecha_cita.Value;

            if (fecha_servicio < DateTime.Now)
            {
                Mensajes.Advertencia("La fecha del servicio no puede ser en el pasado.");
                this.ActiveControl = dtp_fecha_cita;
                return;
            }

            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string query = "";

                    if (operacion == null)
                    {
                        query = "INSERT INTO citas(num_empleado, num_cita, num_tipo_servicio, nombre, apellido_paterno, apellido_materno, fecha_servicio) " +
                                "VALUES(@num_empleado, " +
                                "(SELECT COALESCE(MAX(c.num_cita), 0) + 1 FROM citas c WHERE c.num_empleado = @num_empleado), " +
                                "@num_tipo_servicio, @nombre, @apellido_paterno, @apellido_materno, @fecha_servicio)";
                    }
                    else if (operacion == "edicion")
                    {
                        query = "UPDATE citas SET num_tipo_servicio = @num_tipo_servicio, nombre = @nombre, " +
                                "apellido_paterno = @apellido_paterno, apellido_materno = @apellido_materno, " +
                                "fecha_servicio = @fecha_servicio " +
                                "WHERE num_empleado = @num_empleado AND num_cita = @num_cita";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@num_empleado", num_empleado);
                    cmd.Parameters.AddWithValue("@num_tipo_servicio", num_tipo_servicio);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido_paterno", apellido_paterno);
                    cmd.Parameters.AddWithValue("@apellido_materno", apellido_materno);
                    cmd.Parameters.AddWithValue("@fecha_servicio", fecha_servicio);

                    if (operacion == "edicion")
                    {
                        cmd.Parameters.AddWithValue("@num_cita", num_cita);
                    }

                    await cmd.ExecuteNonQueryAsync();

                    if (operacion == null)
                    {
                        Mensajes.Informacion("Cita agendada exitosamente.");

                        cb_servicios.SelectedIndex = 0;
                        txt_nombre.Clear();
                        txt_apellido_paterno.Clear();
                        txt_apellido_materno.Clear();
                        dtp_fecha_cita.Value = DateTime.Now;
                    }
                    else if (operacion == "edicion")
                    {
                        Mensajes.Informacion("Cita modificada exitosamente.");
                    }

                    pantalla_gestionar_citas.CargarCitas();
                }
                catch (Exception ex)
                {
                    Mensajes.Error("No se pudo guardar la cita. Intentar nuevamente.");
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            pantalla_gestionar_citas.Show();

            this.Close();
        }
    }
}
