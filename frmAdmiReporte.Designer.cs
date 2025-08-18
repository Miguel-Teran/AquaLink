namespace ProyectoAquaLink
{
    partial class frmAdmiReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmiReporte));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.btnEncuestas = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.ctFecha = new System.Windows.Forms.TextBox();
            this.GridReporte = new System.Windows.Forms.DataGridView();
            this.Id_Reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctDescripcion = new System.Windows.Forms.TextBox();
            this.ctUbicacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Descripción = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctReporte = new System.Windows.Forms.TextBox();
            this.Reporte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctUsuario = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2051, 975);
            this.panel2.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1776, 925);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.pnlReportes);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2051, 735);
            this.panel3.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(40, 400);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 110);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.LightCyan;
            this.pnlReportes.Controls.Add(this.ctFecha);
            this.pnlReportes.Controls.Add(this.GridReporte);
            this.pnlReportes.Controls.Add(this.ctDescripcion);
            this.pnlReportes.Controls.Add(this.ctUbicacion);
            this.pnlReportes.Controls.Add(this.label4);
            this.pnlReportes.Controls.Add(this.label3);
            this.pnlReportes.Controls.Add(this.Descripción);
            this.pnlReportes.Controls.Add(this.label2);
            this.pnlReportes.Controls.Add(this.ctReporte);
            this.pnlReportes.Controls.Add(this.Reporte);
            this.pnlReportes.Controls.Add(this.label1);
            this.pnlReportes.Controls.Add(this.ctUsuario);
            this.pnlReportes.Location = new System.Drawing.Point(189, 39);
            this.pnlReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(1820, 655);
            this.pnlReportes.TabIndex = 2;
            // 
            // ctFecha
            // 
            this.ctFecha.Location = new System.Drawing.Point(59, 197);
            this.ctFecha.Name = "ctFecha";
            this.ctFecha.Size = new System.Drawing.Size(200, 22);
            this.ctFecha.TabIndex = 12;
            // 
            // GridReporte
            // 
            this.GridReporte.AllowUserToAddRows = false;
            this.GridReporte.AllowUserToDeleteRows = false;
            this.GridReporte.AllowUserToResizeRows = false;
            this.GridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Reporte,
            this.Ubicacion,
            this.Descripcion,
            this.Fecha,
            this.Id_Usuario});
            this.GridReporte.Location = new System.Drawing.Point(505, 95);
            this.GridReporte.MultiSelect = false;
            this.GridReporte.Name = "GridReporte";
            this.GridReporte.RowHeadersVisible = false;
            this.GridReporte.RowHeadersWidth = 51;
            this.GridReporte.RowTemplate.Height = 24;
            this.GridReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridReporte.Size = new System.Drawing.Size(833, 522);
            this.GridReporte.TabIndex = 11;
            this.GridReporte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridReporte_CellClick);
            // 
            // Id_Reporte
            // 
            this.Id_Reporte.DataPropertyName = "Id_reporte";
            this.Id_Reporte.HeaderText = "Reporte";
            this.Id_Reporte.MinimumWidth = 6;
            this.Id_Reporte.Name = "Id_Reporte";
            this.Id_Reporte.Width = 125;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Ubicación";
            this.Ubicacion.MinimumWidth = 6;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Id_Usuario
            // 
            this.Id_Usuario.DataPropertyName = "Id_usuario";
            this.Id_Usuario.HeaderText = "Usuario";
            this.Id_Usuario.MinimumWidth = 6;
            this.Id_Usuario.Name = "Id_Usuario";
            this.Id_Usuario.Width = 125;
            // 
            // ctDescripcion
            // 
            this.ctDescripcion.Location = new System.Drawing.Point(61, 448);
            this.ctDescripcion.Multiline = true;
            this.ctDescripcion.Name = "ctDescripcion";
            this.ctDescripcion.Size = new System.Drawing.Size(367, 169);
            this.ctDescripcion.TabIndex = 10;
            // 
            // ctUbicacion
            // 
            this.ctUbicacion.Location = new System.Drawing.Point(62, 270);
            this.ctUbicacion.Multiline = true;
            this.ctUbicacion.Name = "ctUbicacion";
            this.ctUbicacion.Size = new System.Drawing.Size(366, 112);
            this.ctUbicacion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(879, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reportes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // Descripción
            // 
            this.Descripción.AutoSize = true;
            this.Descripción.Location = new System.Drawing.Point(59, 420);
            this.Descripción.Name = "Descripción";
            this.Descripción.Size = new System.Drawing.Size(79, 16);
            this.Descripción.TabIndex = 5;
            this.Descripción.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ubicación";
            // 
            // ctReporte
            // 
            this.ctReporte.Location = new System.Drawing.Point(59, 71);
            this.ctReporte.Name = "ctReporte";
            this.ctReporte.Size = new System.Drawing.Size(100, 22);
            this.ctReporte.TabIndex = 3;
            this.ctReporte.Leave += new System.EventHandler(this.ctReporte_Leave);
            // 
            // Reporte
            // 
            this.Reporte.AutoSize = true;
            this.Reporte.Location = new System.Drawing.Point(58, 52);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(80, 16);
            this.Reporte.TabIndex = 2;
            this.Reporte.Text = "No. Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // ctUsuario
            // 
            this.ctUsuario.Location = new System.Drawing.Point(61, 142);
            this.ctUsuario.Name = "ctUsuario";
            this.ctUsuario.Size = new System.Drawing.Size(100, 22);
            this.ctUsuario.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(40, 219);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 110);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(40, 39);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 110);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(40, 583);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 110);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmAdmiReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 979);
            this.Controls.Add(this.panel2);
            this.Name = "frmAdmiReporte";
            this.Text = "Administador Reporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmiReporte_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlReportes.ResumeLayout(false);
            this.pnlReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsumo;
        private System.Windows.Forms.Button btnEncuestas;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.TextBox ctFecha;
        private System.Windows.Forms.DataGridView GridReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Usuario;
        private System.Windows.Forms.TextBox ctDescripcion;
        private System.Windows.Forms.TextBox ctUbicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Descripción;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctReporte;
        private System.Windows.Forms.Label Reporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctUsuario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
    }
}