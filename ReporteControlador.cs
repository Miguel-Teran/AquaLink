using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAquaLink
{
    internal class ReporteControlador
    {
        public ReporteControlador()
        {

        }
        public bool AgregarReporte(Reporte reporte)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Ins_Reporte", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Reporte", reporte.Id_reporte);
                cmd.Parameters.AddWithValue("@Ubicacion", reporte.Ubicacion);
                cmd.Parameters.AddWithValue("@Descripcion", reporte.Descripcion);
                cmd.Parameters.AddWithValue("@Id_Usuario", reporte.Id_usuario);
                cmd.Parameters.AddWithValue("@Fecha", reporte.Fecha);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ActualizarReporte(Reporte reporte)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Act_Reporte", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Reporte", reporte.Id_reporte);
                cmd.Parameters.AddWithValue("@Ubicacion", reporte.Ubicacion);
                cmd.Parameters.AddWithValue("@Descripcion", reporte.Descripcion);
                cmd.Parameters.AddWithValue("@Id_Usuario", reporte.Id_usuario);
                cmd.Parameters.AddWithValue("@Fecha", reporte.Fecha);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Reporte ObtenerReporte(int id)
        {
            Reporte rep = null;
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable datos = new DataTable();
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Bus_Reporte", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Reporte", id);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    rep = new Reporte
                    {
                        Id_reporte = Convert.ToInt32(datos.Rows[0].ItemArray[0]),
                        Ubicacion = datos.Rows[0].ItemArray[1].ToString(),
                        Descripcion = datos.Rows[0].ItemArray[2].ToString(),
                        Fecha = datos.Rows[0].ItemArray[3].ToString(),
                        Id_usuario = Convert.ToInt32(datos.Rows[0].ItemArray[4]),
                    };
                }
                return rep;
            }
            catch
            {
                return null;
            }
        }
        public bool eliminarReporte(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Bor_Reporte", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Reporte", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        } 
        public List<Reporte> ListarReporte()
        {
            SqlConnection conn = new SqlConnection(Conexion.strConexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable datos = new DataTable();
            List <Reporte> reportes = new List<Reporte>();

            try
            {
                if(conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Lis_Reporte", conn);
                cmd.CommandType = CommandType.StoredProcedure; 
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        reportes.Add(new Reporte
                        {
                            Id_reporte = Convert.ToInt32(datos.Rows[i].ItemArray[0]),
                            Ubicacion = datos.Rows[i].ItemArray[1].ToString(),
                            Descripcion = datos.Rows[i].ItemArray[2].ToString(),
                            Fecha = datos.Rows [i].ItemArray[3].ToString(),
                            Id_usuario = Convert.ToInt32(datos.Rows[i].ItemArray[4]),
                        }
                        );
                    }
                }
                return reportes;
            }
            catch
            {
                return reportes;
            }
        }
    }
}
