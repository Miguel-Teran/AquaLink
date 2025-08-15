using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAquaLink
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //-------
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (ctUsuario.Text.Trim().ToUpper() == "ADMIN")
            {
                if (ctPassword.Text.Trim().ToUpper() == "1234")
                {
                    MDInicio principal = new MDInicio();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password incorrecto!!!", "Accediendo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Usuario no existente!!!", "Accediendo",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrearCuenta_Click_1(object sender, EventArgs e)
        {

            Registro crear = new Registro();
            crear.Show();
            this.Hide();
        }
    }
    
}
