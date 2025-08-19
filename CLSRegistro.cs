using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAquaLink
{
    internal class CLSRegistro
    {
        private int usuarioID; 
        private string contraseña;
        private string email;

        public CLSRegistro(int usuarioID, string contraseña, string email)
        {
            this.usuarioID = usuarioID;
            this.contraseña = contraseña;
            this.email = email;
        }

      
        public CLSRegistro(string contraseña, string email)
        {
            this.contraseña = contraseña;
            this.email = email;
        }

        public CLSRegistro()
        {

        }

        public int UsuarioID { get => usuarioID; set => usuarioID = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Email { get => email; set => email = value; }
    }
}
