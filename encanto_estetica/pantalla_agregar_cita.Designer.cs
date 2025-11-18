using System;

namespace Encanto_Estetica
{
    partial class pantalla_agregar_cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_agregar_cita));
            this.lbl_encabezado = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido_paterno = new System.Windows.Forms.TextBox();
            this.txt_apellido_materno = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido_paterno = new System.Windows.Forms.Label();
            this.lbl_apellido_materno = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.cb_servicios = new System.Windows.Forms.ComboBox();
            this.lbl_puesto = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dtp_fecha_cita = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_encabezado
            // 
            this.lbl_encabezado.AutoSize = true;
            this.lbl_encabezado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_encabezado.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encabezado.Location = new System.Drawing.Point(126, 17);
            this.lbl_encabezado.Name = "lbl_encabezado";
            this.lbl_encabezado.Size = new System.Drawing.Size(218, 32);
            this.lbl_encabezado.TabIndex = 0;
            this.lbl_encabezado.Text = "Agendar Cita";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(131, 90);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(392, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_apellido_paterno
            // 
            this.txt_apellido_paterno.Location = new System.Drawing.Point(131, 115);
            this.txt_apellido_paterno.Name = "txt_apellido_paterno";
            this.txt_apellido_paterno.Size = new System.Drawing.Size(392, 20);
            this.txt_apellido_paterno.TabIndex = 2;
            // 
            // txt_apellido_materno
            // 
            this.txt_apellido_materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_apellido_materno.Location = new System.Drawing.Point(132, 139);
            this.txt_apellido_materno.Name = "txt_apellido_materno";
            this.txt_apellido_materno.Size = new System.Drawing.Size(392, 20);
            this.txt_apellido_materno.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_nombre.Location = new System.Drawing.Point(25, 93);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido_paterno
            // 
            this.lbl_apellido_paterno.AutoSize = true;
            this.lbl_apellido_paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_apellido_paterno.Location = new System.Drawing.Point(25, 117);
            this.lbl_apellido_paterno.Name = "lbl_apellido_paterno";
            this.lbl_apellido_paterno.Size = new System.Drawing.Size(84, 13);
            this.lbl_apellido_paterno.TabIndex = 6;
            this.lbl_apellido_paterno.Text = "Apellido Paterno";
            // 
            // lbl_apellido_materno
            // 
            this.lbl_apellido_materno.AutoSize = true;
            this.lbl_apellido_materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_apellido_materno.Location = new System.Drawing.Point(26, 141);
            this.lbl_apellido_materno.Name = "lbl_apellido_materno";
            this.lbl_apellido_materno.Size = new System.Drawing.Size(86, 13);
            this.lbl_apellido_materno.TabIndex = 8;
            this.lbl_apellido_materno.Text = "Apellido Materno";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(321, 227);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(202, 23);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agendar Cita";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(321, 256);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(202, 23);
            this.btn_regresar.TabIndex = 10;
            this.btn_regresar.Text = "Volver";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // cb_servicios
            // 
            this.cb_servicios.FormattingEnabled = true;
            this.cb_servicios.Location = new System.Drawing.Point(131, 64);
            this.cb_servicios.Name = "cb_servicios";
            this.cb_servicios.Size = new System.Drawing.Size(184, 21);
            this.cb_servicios.TabIndex = 12;
            // 
            // lbl_puesto
            // 
            this.lbl_puesto.AutoSize = true;
            this.lbl_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_puesto.Location = new System.Drawing.Point(25, 67);
            this.lbl_puesto.Name = "lbl_puesto";
            this.lbl_puesto.Size = new System.Drawing.Size(45, 13);
            this.lbl_puesto.TabIndex = 13;
            this.lbl_puesto.Text = "Servicio";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_fecha.Location = new System.Drawing.Point(26, 167);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_fecha.TabIndex = 14;
            this.lbl_fecha.Text = "Fecha";
            // 
            // dtp_fecha_cita
            // 
            this.dtp_fecha_cita.CustomFormat = "dddd, dd \'de\' MMMM \'de\' yyyy \'a las\' HH:mm";
            this.dtp_fecha_cita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_cita.Location = new System.Drawing.Point(131, 164);
            this.dtp_fecha_cita.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_fecha_cita.Name = "dtp_fecha_cita";
            this.dtp_fecha_cita.Size = new System.Drawing.Size(276, 20);
            this.dtp_fecha_cita.TabIndex = 16;
            // 
            // pantalla_agregar_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(543, 293);
            this.Controls.Add(this.dtp_fecha_cita);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_puesto);
            this.Controls.Add(this.cb_servicios);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_apellido_materno);
            this.Controls.Add(this.lbl_apellido_paterno);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_apellido_materno);
            this.Controls.Add(this.txt_apellido_paterno);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_encabezado);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "pantalla_agregar_cita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Cita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_encabezado;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido_paterno;
        private System.Windows.Forms.TextBox txt_apellido_materno;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido_paterno;
        private System.Windows.Forms.Label lbl_apellido_materno;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.ComboBox cb_servicios;
        private System.Windows.Forms.Label lbl_puesto;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.DateTimePicker dtp_fecha_cita;
    }
}