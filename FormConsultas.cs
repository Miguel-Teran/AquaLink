using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoAquaLink.Encuestas;

namespace ProyectoAquaLink
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            txtRespuesta1.Text = DatosEncuesta.respuestas[0];
            txtRespuesta2.Text = DatosEncuesta.respuestas[1];
            txtRespuesta3.Text = DatosEncuesta.respuestas[2];
            txtRespuesta4.Text = DatosEncuesta.respuestas[3];
            txtRespuesta5.Text = DatosEncuesta.respuestas[4];

            txtRespuesta1.ReadOnly = true;
            txtRespuesta2.ReadOnly = true;
            txtRespuesta3.ReadOnly = true;
            txtRespuesta4.ReadOnly = true;
            txtRespuesta5.ReadOnly = true;
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            txtRespuesta1.ReadOnly = false;
            txtRespuesta1.Focus();
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            txtRespuesta2.ReadOnly = false;
            txtRespuesta2.Focus();
        }

        private void btnEditar3_Click(object sender, EventArgs e)
        {
            txtRespuesta3.ReadOnly = false;
            txtRespuesta3.Focus();
        }

        private void btnEditar4_Click(object sender, EventArgs e)
        {
            txtRespuesta4.ReadOnly = false;
            txtRespuesta4.Focus();
        }

        private void btnEditar5_Click(object sender, EventArgs e)
        {
            txtRespuesta5.ReadOnly = false;
            txtRespuesta5.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DatosEncuesta.respuestas[0] = txtRespuesta1.Text;
            DatosEncuesta.respuestas[1] = txtRespuesta2.Text;
            DatosEncuesta.respuestas[2] = txtRespuesta3.Text;
            DatosEncuesta.respuestas[3] = txtRespuesta4.Text;
            DatosEncuesta.respuestas[4] = txtRespuesta5.Text;

            txtRespuesta1.ReadOnly = true;
            txtRespuesta2.ReadOnly = true;
            txtRespuesta3.ReadOnly = true;
            txtRespuesta4.ReadOnly = true;
            txtRespuesta5.ReadOnly = true;

            btnGuardar.Enabled = false;
            btnEditar1.Enabled = true;
            btnEditar2.Enabled = true;
            btnEditar3.Enabled = true;
            btnEditar4.Enabled = true;
            btnEditar5.Enabled = true;

            MessageBox.Show("Respuestas guardadas correctamente", "Aqualink");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Encuestas encuestas = new Encuestas();
            encuestas.Show();
            this.Hide();
        }

        private void btnHacerEncuesta_Click(object sender, EventArgs e)
        {
            SeleccionEncuesta selector = new SeleccionEncuesta();
            selector.Show();
            this.Hide();
        }

        private void btnConsultarEncuesta_Click(object sender, EventArgs e)
        {
            SeleccionEncuesta selector = new SeleccionEncuesta();
            selector.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDInicio mDInicio = new MDInicio();
            mDInicio.Show();
            this.Hide();
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            frmGraficas graficas = new frmGraficas();
            graficas.Show();
            this.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            mdiReportes mdiReportes = new mdiReportes();
            mdiReportes.Show();
            this.Hide();
        }

        private void FormConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
