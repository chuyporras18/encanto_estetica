namespace Encanto_Estetica
{
    partial class pantalla_inicio_sesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_inicio_sesion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_num_empleado = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(417, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(441, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txt_num_empleado
            // 
            this.txt_num_empleado.Location = new System.Drawing.Point(387, 164);
            this.txt_num_empleado.Margin = new System.Windows.Forms.Padding(2);
            this.txt_num_empleado.Name = "txt_num_empleado";
            this.txt_num_empleado.Size = new System.Drawing.Size(167, 20);
            this.txt_num_empleado.TabIndex = 2;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(387, 222);
            this.txt_contrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(167, 20);
            this.txt_contrasena.TabIndex = 3;
            this.txt_contrasena.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_login.Location = new System.Drawing.Point(412, 310);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(115, 28);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Iniciar sesión";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pantalla_inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 420);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_num_empleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pantalla_inicio_sesion";
            this.Text = "Iniciar Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_num_empleado;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Button btn_login;
    }
}

