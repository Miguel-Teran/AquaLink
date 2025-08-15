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
    public partial class frmGraficas : Form
    {
        public frmGraficas()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MDInicio inicio = new MDInicio();
            inicio.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            mdiReportes reportes = new mdiReportes();
            reportes.Show();
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
