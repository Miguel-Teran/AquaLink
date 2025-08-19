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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idusuario;
            string email, contraseña;

            idusuario = Convert.ToInt32(UsuarioR.Text.Trim());
            email = EmailR.Text.Trim();
            contraseña = EmailR.Text.Trim();
            CLSRegistro reg = new CLSRegistro(idusuario, email, contraseña);
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
