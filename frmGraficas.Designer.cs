namespace ProyectoAquaLink
{
    partial class frmGraficas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraficas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnEncuestas = new System.Windows.Forms.Button();
            this.btnDía = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnAño = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2050, 975);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.pnlReportes);
            this.panel3.Controls.Add(this.btnDía);
            this.panel3.Controls.Add(this.btnMes);
            this.panel3.Controls.Add(this.btnAño);
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2050, 735);
            this.panel3.TabIndex = 1;
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.LightCyan;
            this.pnlReportes.Location = new System.Drawing.Point(190, 40);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(1820, 655);
            this.pnlReportes.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btnReportes);
            this.panel2.Controls.Add(this.btnEncuestas);
            this.panel2.Controls.Add(this.btnInicio);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2050, 80);
            this.panel2.TabIndex = 0;
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(390, 15);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(100, 50);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnEncuestas
            // 
            this.btnEncuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncuestas.Location = new System.Drawing.Point(190, 15);
            this.btnEncuestas.Name = "btnEncuestas";
            this.btnEncuestas.Size = new System.Drawing.Size(100, 50);
            this.btnEncuestas.TabIndex = 2;
            this.btnEncuestas.Text = "Encuestas";
            this.btnEncuestas.UseVisualStyleBackColor = true;
            this.btnEncuestas.Click += new System.EventHandler(this.btnEncuestas_Click);
            // 
            // btnDía
            // 
            this.btnDía.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDía.BackgroundImage")));
            this.btnDía.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDía.Location = new System.Drawing.Point(40, 584);
            this.btnDía.Name = "btnDía";
            this.btnDía.Size = new System.Drawing.Size(110, 110);
            this.btnDía.TabIndex = 4;
            this.btnDía.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDía.UseVisualStyleBackColor = true;
            // 
            // btnMes
            // 
            this.btnMes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMes.BackgroundImage")));
            this.btnMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMes.Location = new System.Drawing.Point(40, 312);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(110, 110);
            this.btnMes.TabIndex = 3;
            this.btnMes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMes.UseVisualStyleBackColor = true;
            // 
            // btnAño
            // 
            this.btnAño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAño.BackgroundImage")));
            this.btnAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAño.ForeColor = System.Drawing.Color.Black;
            this.btnAño.Location = new System.Drawing.Point(40, 40);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(110, 110);
            this.btnAño.TabIndex = 2;
            this.btnAño.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAño.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.Location = new System.Drawing.Point(40, 15);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(50, 50);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // frmGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 979);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGraficas";
            this.Text = "frmGraficas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnEncuestas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnDía;
        private System.Windows.Forms.Panel pnlReportes;
    }
}