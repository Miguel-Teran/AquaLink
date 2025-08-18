namespace ProyectoAquaLink
{
    partial class mdiReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiReportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.btnEncuestas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnAdmi = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnEstatus = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnTerminados = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btnAdmi);
            this.panel1.Controls.Add(this.btnConsumo);
            this.panel1.Controls.Add(this.btnEncuestas);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2051, 80);
            this.panel1.TabIndex = 2;
            // 
            // btnConsumo
            // 
            this.btnConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumo.Location = new System.Drawing.Point(389, 15);
            this.btnConsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(100, 50);
            this.btnConsumo.TabIndex = 2;
            this.btnConsumo.Text = "Consumo";
            this.btnConsumo.UseVisualStyleBackColor = true;
            this.btnConsumo.Click += new System.EventHandler(this.btnConsumo_Click);
            // 
            // btnEncuestas
            // 
            this.btnEncuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncuestas.Location = new System.Drawing.Point(189, 15);
            this.btnEncuestas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncuestas.Name = "btnEncuestas";
            this.btnEncuestas.Size = new System.Drawing.Size(100, 50);
            this.btnEncuestas.TabIndex = 1;
            this.btnEncuestas.Text = "Encuestas";
            this.btnEncuestas.UseVisualStyleBackColor = true;
            this.btnEncuestas.Click += new System.EventHandler(this.btnEncuestas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2051, 975);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Controls.Add(this.pnlReportes);
            this.panel3.Controls.Add(this.btnEstatus);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.btnTerminados);
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2051, 735);
            this.panel3.TabIndex = 0;
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.LightCyan;
            this.pnlReportes.Location = new System.Drawing.Point(189, 39);
            this.pnlReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(1820, 655);
            this.pnlReportes.TabIndex = 2;
            // 
            // btnAdmi
            // 
            this.btnAdmi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmi.BackgroundImage")));
            this.btnAdmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmi.Location = new System.Drawing.Point(1822, 12);
            this.btnAdmi.Name = "btnAdmi";
            this.btnAdmi.Size = new System.Drawing.Size(75, 53);
            this.btnAdmi.TabIndex = 3;
            this.btnAdmi.UseVisualStyleBackColor = true;
            this.btnAdmi.Click += new System.EventHandler(this.btnAdmi_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.Location = new System.Drawing.Point(40, 15);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(51, 50);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnEstatus
            // 
            this.btnEstatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstatus.BackgroundImage")));
            this.btnEstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstatus.Location = new System.Drawing.Point(40, 313);
            this.btnEstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEstatus.Name = "btnEstatus";
            this.btnEstatus.Size = new System.Drawing.Size(109, 110);
            this.btnEstatus.TabIndex = 2;
            this.btnEstatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnEstatus.UseVisualStyleBackColor = true;
            this.btnEstatus.Click += new System.EventHandler(this.btnEstatus_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(40, 39);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 110);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnTerminados
            // 
            this.btnTerminados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTerminados.BackgroundImage")));
            this.btnTerminados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminados.Location = new System.Drawing.Point(40, 583);
            this.btnTerminados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTerminados.Name = "btnTerminados";
            this.btnTerminados.Size = new System.Drawing.Size(109, 110);
            this.btnTerminados.TabIndex = 3;
            this.btnTerminados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTerminados.UseVisualStyleBackColor = true;
            this.btnTerminados.Click += new System.EventHandler(this.btnTerminados_Click);
            // 
            // mdiReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 978);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mdiReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsumo;
        private System.Windows.Forms.Button btnEncuestas;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEstatus;
        private System.Windows.Forms.Button btnTerminados;
        private System.Windows.Forms.Button btnAdmi;
    }
}