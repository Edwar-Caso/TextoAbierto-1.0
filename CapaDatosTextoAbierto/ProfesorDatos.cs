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
    public class ProfesorDatos
    {
        public void Insertar(Profesor DProfesor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "INSERT INTO tblProfesor (IDProfesor, proNmbre) VALUES (@IDProfesor, @proNmbre)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {

                    cmd.Parameters.AddWithValue("@IDProfesor", DProfesor.IdProfesor);
                    cmd.Parameters.AddWithValue("@proNmbre", DProfesor.proNombre);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Actualizar(Profesor DProfesor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE tblProfesor SET proNmbre = @proNmbre WHERE IDProfesor = @IDProfesor";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@IDProfesor", DProfesor.IdProfesor);
                    cmd.Parameters.AddWithValue("@proNmbre", DProfesor.proNombre);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Eliminar(int IdProfesor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM tblPregunta WHERE IDProfesor = @IDProfesor";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@IDPregunta", IdProfesor);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public Profesor GetByid(int IdProfesor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM tblPregunta WHERE IDProfesor = @IDProfesor";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {

                    cmd.Parameters.AddWithValue("@IDProfesor", IdProfesor);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        Profesor LProfesor = new Profesor
                        {
                            IdProfesor = Convert.ToInt32(dataReader["IDProfesor"]),
                            proNombre = Convert.ToString(dataReader["proNmbre"])
                        };

                        return LProfesor;
                    }
                }
            }
            return null;
        }
    }
}
