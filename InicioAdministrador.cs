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
    public partial class InicioAdministrador : Form
    {
        public InicioAdministrador()
        {
            InitializeComponent();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmAdmiReporte admirepor = new frmAdmiReporte();
            admirepor.Show();
            this.Hide();
        }

        private void btnEncuesta_Click(object sender, EventArgs e)
        {
            EncuestasAdministrador admirepor = new EncuestasAdministrador();
            admirepor.Show();
            this.Hide();
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            frmGraficas admirepor = new frmGraficas();
            admirepor.Show();
            this.Hide();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Administracion_Usuario admirepor = new Administracion_Usuario();
            admirepor.Show();
            this.Hide();
        }
    }
}
