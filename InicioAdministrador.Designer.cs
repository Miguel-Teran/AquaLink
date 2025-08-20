namespace ProyectoAquaLink
{
    partial class InicioAdministrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnGraficas = new System.Windows.Forms.Button();
            this.btnEncuesta = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(756, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 73);
            this.label1.TabIndex = 28;
            this.label1.Text = "Administrador";
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.Navy;
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1924, 80);
            this.PanelSuperior.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnInformacion);
            this.panel2.Controls.Add(this.btnReportes);
            this.panel2.Controls.Add(this.btnGraficas);
            this.panel2.Controls.Add(this.btnEncuesta);
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2050, 735);
            this.panel2.TabIndex = 26;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(790, 510);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(360, 65);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.Location = new System.Drawing.Point(790, 410);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(360, 65);
            this.btnInformacion.TabIndex = 19;
            this.btnInformacion.Text = "Modificar usuarios";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(790, 110);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(360, 65);
            this.btnReportes.TabIndex = 16;
            this.btnReportes.Text = "Administrar reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnGraficas
            // 
            this.btnGraficas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficas.Location = new System.Drawing.Point(790, 310);
            this.btnGraficas.Name = "btnGraficas";
            this.btnGraficas.Size = new System.Drawing.Size(360, 65);
            this.btnGraficas.TabIndex = 18;
            this.btnGraficas.Text = "Revisar graficas";
            this.btnGraficas.UseVisualStyleBackColor = true;
            this.btnGraficas.Click += new System.EventHandler(this.btnGraficas_Click);
            // 
            // btnEncuesta
            // 
            this.btnEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncuesta.Location = new System.Drawing.Point(790, 210);
            this.btnEncuesta.Name = "btnEncuesta";
            this.btnEncuesta.Size = new System.Drawing.Size(360, 65);
            this.btnEncuesta.TabIndex = 17;
            this.btnEncuesta.Text = "Modificar encuesta";
            this.btnEncuesta.UseVisualStyleBackColor = true;
            this.btnEncuesta.Click += new System.EventHandler(this.btnEncuesta_Click);
            // 
            // InicioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1924, 936);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.panel2);
            this.Name = "InicioAdministrador";
            this.Text = "InicioAdministrador";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnGraficas;
        private System.Windows.Forms.Button btnEncuesta;
    }
}