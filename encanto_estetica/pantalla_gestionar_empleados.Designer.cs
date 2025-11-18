using System.Drawing;
using System.Windows.Forms;

namespace Encanto_Estetica
{
    partial class pantalla_gestionar_empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_gestionar_empleados));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.btn_eliminar_empleado = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_agregar_usuario = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(85, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "GESTIÓN DE EMPLEADOS";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(63, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione el empleado:";
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.MistyRose;
            this.btn_consultar.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_consultar.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_consultar.Location = new System.Drawing.Point(67, 205);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(91, 39);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.AllowUserToAddRows = false;
            this.dgv_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_empleados.BackgroundColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_empleados.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_empleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_empleados.GridColor = System.Drawing.Color.DarkRed;
            this.dgv_empleados.Location = new System.Drawing.Point(304, 129);
            this.dgv_empleados.MultiSelect = false;
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.ReadOnly = true;
            this.dgv_empleados.RowHeadersWidth = 51;
            this.dgv_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_empleados.Size = new System.Drawing.Size(568, 350);
            this.dgv_empleados.TabIndex = 4;
            // 
            // btn_eliminar_empleado
            // 
            this.btn_eliminar_empleado.BackColor = System.Drawing.Color.MistyRose;
            this.btn_eliminar_empleado.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_eliminar_empleado.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_eliminar_empleado.Location = new System.Drawing.Point(67, 279);
            this.btn_eliminar_empleado.Name = "btn_eliminar_empleado";
            this.btn_eliminar_empleado.Size = new System.Drawing.Size(200, 40);
            this.btn_eliminar_empleado.TabIndex = 6;
            this.btn_eliminar_empleado.Text = "Eliminar";
            this.btn_eliminar_empleado.UseVisualStyleBackColor = false;
            this.btn_eliminar_empleado.Click += new System.EventHandler(this.btn_eliminar_empleado_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.MistyRose;
            this.btn_actualizar.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_actualizar.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_actualizar.Location = new System.Drawing.Point(92, 349);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(150, 35);
            this.btn_actualizar.TabIndex = 8;
            this.btn_actualizar.Text = "Actualizar Tabla";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_agregar_usuario
            // 
            this.btn_agregar_usuario.BackColor = System.Drawing.Color.DarkRed;
            this.btn_agregar_usuario.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_agregar_usuario.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_agregar_usuario.Location = new System.Drawing.Point(304, 498);
            this.btn_agregar_usuario.Name = "btn_agregar_usuario";
            this.btn_agregar_usuario.Size = new System.Drawing.Size(154, 40);
            this.btn_agregar_usuario.TabIndex = 13;
            this.btn_agregar_usuario.Text = "Agregar Empleado";
            this.btn_agregar_usuario.UseVisualStyleBackColor = false;
            this.btn_agregar_usuario.Click += new System.EventHandler(this.btn_agregar_empleado_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.MistyRose;
            this.btn_regresar.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_regresar.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_regresar.Location = new System.Drawing.Point(723, 501);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(149, 35);
            this.btn_regresar.TabIndex = 14;
            this.btn_regresar.Text = "Volver";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Arial", 10F);
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(176, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_actualizar_empleado_Click);
            // 
            // pantalla_gestionar_empleados
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_agregar_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.btn_eliminar_empleado);
            this.Controls.Add(this.btn_actualizar);
            this.Name = "pantalla_gestionar_empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_eliminar_empleado;
        private System.Windows.Forms.Button btn_actualizar;
        private Button btn_agregar_usuario;
        private Button btn_regresar;
        private Button button1;
    }
}