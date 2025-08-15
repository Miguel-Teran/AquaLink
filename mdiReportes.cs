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
    public partial class mdiReportes : Form
    {
        public mdiReportes()
        {
            InitializeComponent();
        }

        private void frompanel(object frompan)
        {
            if (this.pnlReportes.Controls.Count > 0)
                this.pnlReportes.Controls.RemoveAt(0);
            Form agr = frompan as Form;
            agr.TopLevel = false;
            agr.Dock = DockStyle.Fill;
            this.pnlReportes.Controls.Add(agr);
            this.pnlReportes.Tag = agr;
            agr.Show();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frompanel(new frmAgregarReporte());
        }

        private void btnEstatus_Click(object sender, EventArgs e)
        {
            frompanel(new frmEstatus());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MDInicio inicio = new MDInicio();
            inicio.Show();
            this.Hide();
        }

        private void btnTerminados_Click(object sender, EventArgs e)
        {
            frompanel(new frmTerminados());
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            frmGraficas graficas = new frmGraficas();
            graficas.Show();
            this.Hide();
        }

        private void btnEncuestas_Click(object sender, EventArgs e)
        {
            Encuestas encuestas = new Encuestas();
            encuestas.Show();
            this.Hide();
        }
    }
}
