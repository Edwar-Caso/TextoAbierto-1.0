using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidadesTextoAbierto;

namespace CapaDatosTextoAbierto
{
    public class RespuestaDatos
    {
        public void Insertar(Respuesta Drespuesta)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "INSERT INTO Respuesta (Id_Respuesta, Id_cuestionario, nombre_alumno, respuesta) VALUES (@Id_Reporte, @Id_Cuestionario, @nombre_alumno, @respuesta)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {

                    cmd.Parameters.AddWithValue("@Id_Respuesta", Drespuesta.Id_respuesta);
                    cmd.Parameters.AddWithValue("@Id_Cuestionario", Drespuesta.Id_cuestionario);
                    cmd.Parameters.AddWithValue("@nombre_alumno", Drespuesta.nombre_alumno);
                    cmd.Parameters.AddWithValue("@respuesta", Drespuesta.respuesta);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Actualizar(Respuesta Drespuesta)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE Respuesta SET Id_cuestionario = @Id_Cuestionario, nombre_alumno = @nombre_alumno, respuesta = @respuesta WHERE Id_Respuesta = @Id_Respuesta";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@Id_Respuesta", Drespuesta.Id_respuesta);
                    cmd.Parameters.AddWithValue("@Id_Cuestionario", Drespuesta.Id_cuestionario);
                    cmd.Parameters.AddWithValue("@nombre_alumno", Drespuesta.nombre_alumno);
                    cmd.Parameters.AddWithValue("@respuesta", Drespuesta.respuesta);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Eliminar(int Id_Respuesta)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM Respuesta WHERE Id_Respuesta = @Id_Respuesta";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@Id_Respuesta", Id_Respuesta);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public Respuesta GetByid(int Id_Respuesta)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM Respuesta WHERE Id_Respuesta = @Id_Respuesta";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {

                    cmd.Parameters.AddWithValue("@Id_Respuesta", Id_Respuesta);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        Respuesta Lrespuesta = new Respuesta
                        {
                            Id_respuesta = Convert.ToInt32(dataReader["Id_Respuesta"]),
                            Id_cuestionario = Convert.ToInt32(dataReader["Id_Cuestionario"]),
                            nombre_alumno = Convert.ToString(dataReader["nombre_alumno"]),
                            respuesta = Convert.ToString(dataReader["pregunta"]),
                        };

                        return Lrespuesta;
                    }
                }
            }
            return null;
        }
    }
}
