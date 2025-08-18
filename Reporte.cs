using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAquaLink
{
    internal class Reporte
    {
        private int id_reporte;
        private string descripcion;
        private string fecha;
        private string ubicacion;
        private int id_usuario;

        public Reporte()
        {

        }
        public Reporte(int id_reporte, string descripcion, string fecha, string ubicacion, int id_usuario)
        {
            this.id_reporte = id_reporte;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.ubicacion = ubicacion;
            this.id_usuario = id_usuario;
        }

        public int Id_reporte { get => id_reporte; set => id_reporte = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public String Fecha { get => fecha; set => fecha = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }
}