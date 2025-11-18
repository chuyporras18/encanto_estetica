using encanto_estetica;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace Encanto_Estetica
{
    public partial class pantalla_agregar_empleado : Form
    {

        pantalla_gestionar_empleados pantalla_gestionar_empleados;
        private string num_empleado;
        private string operacion;

        public pantalla_agregar_empleado(pantalla_gestionar_empleados pantalla_gestionar_empleados, string num_empeleado, string operacion)
        {
            InitializeComponent();

            this.pantalla_gestionar_empleados = pantalla_gestionar_empleados;
            this.num_empleado = num_empeleado;
            this.operacion = operacion;

            if (operacion == null)
            {
                this.Text = "Agregar Empleado";
            }
            else if (operacion == "edicion")
            {
                this.Text = "Editar Empleado";
            }
            else if (operacion == "consulta")
            {
                this.Text = "Consultar Empleado";
            }

            lbl_encabezado.Text = this.Text;

            CargarPuestos();

            if (num_empleado != null)
            {
                CargarInformacionEmpleado();
            }
        }

        private void CargarInformacionEmpleado()
        {
            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string query = "SELECT nombre, apellido_paterno, apellido_materno, contrasena, num_tipo_empleado " +
                                   "FROM empleados " +
                                   "WHERE num_empleado = @num_empleado";

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@num_empleado", num_empleado);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_nombre.Text = reader["nombre"].ToString();
                        txt_apellido_paterno.Text = reader["apellido_paterno"].ToString();
                        txt_apellido_materno.Text = reader["apellido_materno"].ToString();

                        int num_tipo_empleado = Convert.ToInt32(reader["num_tipo_empleado"]);

                        for (int i = 1; i < cb_puestos.Items.Count; i++)
                        {
                            string item = cb_puestos.Items[i].ToString();
                            int item_num_tipo_empleado = int.Parse(item.Split(':')[0]);

                            if (item_num_tipo_empleado == num_tipo_empleado)
                            {
                                cb_puestos.SelectedIndex = i;
                                break;
                            }
                        }

                        if (operacion == "consulta")
                        {
                            btn_agregar.Visible = false;
                            txt_nombre.Enabled = false;
                            txt_apellido_paterno.Enabled = false;
                            txt_apellido_materno.Enabled = false;
                            txt_contrasena.Enabled = false;
                            cb_puestos.Enabled = false;
                        }

                        if (operacion == "edicion")
                        {
                            txt_contrasena.Text = reader["contrasena"].ToString();
                            btn_agregar.Text = "Guardar Cambios";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mensajes.Error("No se pudo cargar la información del empleado. Intentar nuevamente.");

                    pantalla_gestionar_empleados.Show();

                    this.Close();
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void CargarPuestos()
        {
            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string consulta = "SELECT CONCAT(num_tipo_empleado, ': ', nom_tipo_empleado) AS Puesto FROM tipos_empleado";

                    MySqlCommand cmd = new MySqlCommand(consulta, db.GetConnection());
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cb_puestos.Items.Clear();
                    cb_puestos.Items.Add("-- Seleccione un puesto --");

                    while (reader.Read())
                    {
                        cb_puestos.Items.Add(reader.GetString("Puesto"));
                    }

                    cb_puestos.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    Mensajes.Error("No se pudieron cargar los puestos. Intentar nuevamente.");

                    pantalla_gestionar_empleados.Show();

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
            string nombre = txt_nombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Mensajes.Advertencia("El nombre no puede estar vacío.");
                this.ActiveControl = txt_nombre;
                return;
            }

            string apellido_paterno = txt_apellido_paterno.Text.Trim();

            if (string.IsNullOrWhiteSpace(apellido_paterno))
            {
                Mensajes.Advertencia("El apellido paterno no puede estar vacío.");
                this.ActiveControl = txt_apellido_paterno;
                return;
            }

            string apellido_materno = txt_apellido_materno.Text.Trim();

            if (string.IsNullOrWhiteSpace(apellido_materno))
            {
                Mensajes.Advertencia("El apellido materno no puede estar vacío.");
                this.ActiveControl = txt_apellido_materno;
                return;
            }

            string contrasena = txt_contrasena.Text.Trim();

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                Mensajes.Advertencia("La contraseña no puede estar vacía.");
                this.ActiveControl = txt_contrasena;
                return;
            }

            if (cb_puestos.SelectedIndex <= 0)
            {
                Mensajes.Advertencia("Debe seleccionar un puesto para el empleado.");
                this.ActiveControl = cb_puestos;
                return;
            }

            int num_tipo_empleado = int.Parse(cb_puestos.SelectedItem.ToString().Split(':')[0]);

            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.OpenConnection();

                    string query = "";

                    if (operacion == null)
                    {
                        query = "INSERT INTO empleados(nombre, apellido_paterno, apellido_materno, contrasena, num_tipo_empleado) " +
                                      "VALUES(@nombre, @apellido_paterno, @apellido_materno, @contrasena, @num_tipo_empleado)";
                    }
                    else if (operacion == "edicion")
                    {
                        query = "UPDATE empleados " +
                                   "SET nombre = @nombre, apellido_paterno = @apellido_paterno, apellido_materno = @apellido_materno, " +
                                   "contrasena = @contrasena, num_tipo_empleado = @num_tipo_empleado " +
                                   "WHERE num_empleado = @num_empleado";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido_paterno", apellido_paterno);
                    cmd.Parameters.AddWithValue("@apellido_materno", apellido_materno);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@num_tipo_empleado", num_tipo_empleado);

                    if (operacion == "edicion")
                    {
                        cmd.Parameters.AddWithValue("@num_empleado", num_empleado);
                    }

                    await cmd.ExecuteNonQueryAsync();

                    if (operacion == null)
                    {
                        Mensajes.Informacion("Empleado agregado exitosamente.");

                        txt_nombre.Clear();
                        txt_apellido_paterno.Clear();
                        txt_apellido_materno.Clear();
                        txt_contrasena.Clear();
                        cb_puestos.SelectedIndex = 0;
                    }
                    else if (operacion == "edicion")
                    {
                        Mensajes.Informacion("Empleado actualizado exitosamente.");
                    }

                    pantalla_gestionar_empleados.CargarEmpleados();
                }
                catch (Exception ex)
                {
                    if (operacion == null)
                    {
                        Mensajes.Error("No se pudo agregar el empleado. Intentar nuevamente.");
                    }
                    else if (operacion == "edicion")
                    {
                        Mensajes.Error("No se pudo actualizar el empleado. Intentar nuevamente.");
                    }
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            pantalla_gestionar_empleados.Show();

            this.Close();
        }
    }
}
