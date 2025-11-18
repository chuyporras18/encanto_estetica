using System;

namespace Encanto_Estetica
{
    partial class pantalla_inicio
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
            this.btn_empleados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.btn_citas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_empleados
            // 
            this.btn_empleados.BackColor = System.Drawing.Color.MistyRose;
            this.btn_empleados.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_empleados.Location = new System.Drawing.Point(0, 2);
            this.btn_empleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(117, 36);
            this.btn_empleados.TabIndex = 3;
            this.btn_empleados.Text = "Gestionar Empleados";
            this.btn_empleados.UseVisualStyleBackColor = false;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENCANTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(154, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(656, 73);
            this.label2.TabIndex = 5;
            this.label2.Text = "SALÓN DE BELLEZA";
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.BackColor = System.Drawing.Color.MistyRose;
            this.btn_cerrar_sesion.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(788, 401);
            this.btn_cerrar_sesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(88, 32);
            this.btn_cerrar_sesion.TabIndex = 6;
            this.btn_cerrar_sesion.Text = "Cerrar Sesión";
            this.btn_cerrar_sesion.UseVisualStyleBackColor = false;
            this.btn_cerrar_sesion.Click += new System.EventHandler(this.btn_cerrar_sesion_Click);
            // 
            // btn_citas
            // 
            this.btn_citas.BackColor = System.Drawing.Color.MistyRose;
            this.btn_citas.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_citas.Location = new System.Drawing.Point(123, 2);
            this.btn_citas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_citas.Name = "btn_citas";
            this.btn_citas.Size = new System.Drawing.Size(117, 36);
            this.btn_citas.TabIndex = 7;
            this.btn_citas.Text = "Gestionar Citas";
            this.btn_citas.UseVisualStyleBackColor = false;
            this.btn_citas.Click += new System.EventHandler(this.btn_citas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_empleados);
            this.panel1.Controls.Add(this.btn_citas);
            this.panel1.Location = new System.Drawing.Point(339, 268);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 39);
            this.panel1.TabIndex = 8;
            // 
            // pantalla_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cerrar_sesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "pantalla_inicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void btnIngrearAgregarRuta_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cerrar_sesion;
        private System.Windows.Forms.Button btn_citas;
        private System.Windows.Forms.Panel panel1;
    }
}