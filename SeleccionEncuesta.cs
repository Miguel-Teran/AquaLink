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
    public partial class SeleccionEncuesta : Form
    {
        public SeleccionEncuesta()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnEncuesta1_Click(object sender, EventArgs e)
        {
            Encuestas formularioEncuesta = new Encuestas();
            formularioEncuesta.Show();
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

        private void SeleccionEncuesta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
