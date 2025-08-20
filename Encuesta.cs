using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAquaLink
{
    internal class Encuesta
    {
        public int ID { get; set; }
        public string EncuestaNombre { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public DateTime Fecha { get; set; }

        public class ModeloEncuesta
        {
            public int ID { get; set; }
            public string EncuestaNombre { get; set; }
            public string Pregunta { get; set; }
            public string Respuesta { get; set; }
            public DateTime Fecha { get; set; }
        }
        public class EncuestaController
        {
            List<ModeloEncuesta> listaEncuestas = new List<ModeloEncuesta>();
            private readonly string connectionString = "workstation id=AquaLink.mssql.somee.com;packet size=4096;user id=AquaLink_SQLLogin_1;pwd=khi784impv;data source=AquaLink.mssql.somee.com;persist security info=False;initial catalog=AquaLink";

            public void InsertarEncuesta(ModeloEncuesta encuesta)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("Ins_Encuestas", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EncuestaNombre", encuesta.EncuestaNombre);
                    command.Parameters.AddWithValue("@Pregunta", encuesta.Pregunta);
                    command.Parameters.AddWithValue("@Respuesta", encuesta.Respuesta);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }



            public List<ModeloEncuesta> ObtenerEncuestas()
            {
                List<ModeloEncuesta> listaEncuestas = new List<ModeloEncuesta>();
                string query = "SELECT ID, EncuestaNombre, Pregunta, Respuesta, Fecha FROM Encuestas";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        listaEncuestas.Add(new ModeloEncuesta
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            EncuestaNombre = reader.GetString(reader.GetOrdinal("EncuestaNombre")),
                            Pregunta = reader.GetString(reader.GetOrdinal("Pregunta")),
                            Respuesta = reader.GetString(reader.GetOrdinal("Respuesta")),
                            Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"))
                        });
                    }
                    reader.Close();
                }
                return listaEncuestas;
            }

            public void ActualizarEncuesta(ModeloEncuesta encuesta)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("Act_Encuestas", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", encuesta.ID);
                    command.Parameters.AddWithValue("@EncuestaNombre", encuesta.EncuestaNombre);
                    command.Parameters.AddWithValue("@Pregunta", encuesta.Pregunta);
                    command.Parameters.AddWithValue("@Respuesta", encuesta.Respuesta);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            public void EliminarEncuesta(int id)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("Bor_Encuestas", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
