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
    public partial class MDInicio : Form
    {
        public MDInicio()
        {
            InitializeComponent();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frm_Login frm_Login = new frm_Login();
            frm_Login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void MDInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
        //Cambios Hechos
        private void buttonNtf_Click(object sender, EventArgs e)
        {
            panelDesplegable.Visible = !panelDesplegable.Visible;
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            mdiReportes reportes = new mdiReportes();
            reportes.Show();
            this.Hide();
        }

        private void btnConsumo_Click_1(object sender, EventArgs e)
        {

            frmGraficas grafica = new frmGraficas();
            grafica.Show();
            this.Hide();
        }

        private void btnEncuestas_Click(object sender, EventArgs e)
        {
            Encuestas encuestas = new Encuestas();
            encuestas.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Tema_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.Black)
            {
                panel1.BackColor = Color.DarkBlue;
            }
            else
            {
                panel1.BackColor = Color.Black;
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Notificacion1.Visible = !Notificacion1.Visible;
            Notificacion2.Visible = !Notificacion2.Visible;
            Notificacion3.Visible = !Notificacion3.Visible;
            Notificacion4.Visible = !Notificacion4.Visible;
            Notificacion5.Visible = !Notificacion5.Visible;
            Notificacion6.Visible = !Notificacion6.Visible;
            Notificacion7.Visible = !Notificacion7.Visible;
            Notificacion8.Visible = !Notificacion8.Visible;
            Fecha1.Visible = !Fecha1.Visible;
            Fecha2.Visible = !Fecha2.Visible;
            Fecha3.Visible = !Fecha3.Visible;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Administracion_Usuario administracion = new Administracion_Usuario();
            administracion.Show();
            this.Hide();
        }
    }
}
