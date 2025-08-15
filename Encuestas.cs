using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAquaLink
{
    public partial class Encuestas : Form
    {
        public Encuestas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public static class DatosEncuesta
        {
            public static List<string> respuestas = new List<string>()
            {
                "", "", "", "", ""
            };
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string respuesta1 = txtPregunta1.Text;
            string respuesta2 = txtPregunta2.Text;
            string respuesta3 = txtPregunta3.Text;
            string respuesta4 = txtPregunta4.Text;
            string respuesta5 = txtPregunta5.Text;

            MessageBox.Show("Gracias por responder la encuesta", "Aqualink");

            DatosEncuesta.respuestas.Clear();
            DatosEncuesta.respuestas.Add(txtPregunta1.Text);
            DatosEncuesta.respuestas.Add(txtPregunta2.Text);
            DatosEncuesta.respuestas.Add(txtPregunta3.Text);
            DatosEncuesta.respuestas.Add(txtPregunta4.Text);
            DatosEncuesta.respuestas.Add(txtPregunta5.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDInicio mDInicio = new MDInicio();
            mDInicio.Show();
            this.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            mdiReportes mdiReportes = new mdiReportes();
            mdiReportes.Show();
            this.Hide();
        }

        private void Encuestas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            frmGraficas graficas = new frmGraficas();
            graficas.Show();
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
            FormConsultas formConsulta = new FormConsultas();
            formConsulta.Show();
            this.Hide();
        }
    }
}
