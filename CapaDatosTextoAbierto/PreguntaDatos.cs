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
    public class PreguntaDatos
    {
        public void Insertar(Pregunta DPregunta)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "INSERT INTO tblPregunta (IDPregunta, Pregunta, Descripcion, Imagen, IDProfesor) VALUES (@IDPregunta, @Pregunta, @Descripcion, @Imagen, @IDProfesor)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
              
                    cmd.Parameters.AddWithValue("@IDPregunta", DPregunta.IdProfesor);
                    cmd.Parameters.AddWithValue("@Pregunta", DPregunta.pregunta);
                    cmd.Parameters.AddWithValue("@Descripcion", DPregunta.descripcion);
                    cmd.Parameters.AddWithValue("@Imagen", DPregunta.imagen);
                    cmd.Parameters.AddWithValue("@IDProfesor", DPregunta.IdProfesor);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Actualizar(Pregunta DPregunta)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE tblPregunta SET Pregunta = @pregunta, Descripcion = @descripcion, imagen = @imagen, IDProfesor = @IDProfesor WHERE IDPregunta = @IDPregunta";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@IDPregunta", DPregunta.IdProfesor);
                    cmd.Parameters.AddWithValue("@Pregunta", DPregunta.pregunta);
                    cmd.Parameters.AddWithValue("@Descripcion", DPregunta.descripcion);
                    cmd.Parameters.AddWithValue("@Imagen", DPregunta.imagen);
                    cmd.Parameters.AddWithValue("@IDProfesor", DPregunta.IdProfesor);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Eliminar(int IdPregunta)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM tblPregunta WHERE IDPregunta = @IDPregunta";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@IDPregunta", IdPregunta);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public Pregunta GetByid(int IdPregunta)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM tblPregunta WHERE IDPregunta = @IDPregunta";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                   
                    cmd.Parameters.AddWithValue("@IDPregunta", IdPregunta);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        Pregunta LPregunta = new Pregunta
                        {
                            IdPregunta = Convert.ToInt32(dataReader["IDPregunta"]),
                            pregunta = Convert.ToString(dataReader["pregunta"]),
                            descripcion = Convert.ToString(dataReader["descripcion"]),
                            imagen = Convert.ToByte(dataReader["Imagen"]),
                            IdProfesor = Convert.ToInt32(dataReader["Profesor"])
                        };

                        return LPregunta;
                    }
                }
            }
            return null;
        }
    }
}
