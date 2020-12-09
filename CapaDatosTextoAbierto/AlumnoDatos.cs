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
    public class AlumnoDatos
    {
        public void Insertar(Alumno DAlumno)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "INSERT INTO tblAlumno (IDAlumno, alumNombre) VALUES (@IDAlumno, @alumNombre)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {

                    cmd.Parameters.AddWithValue("@IDAlumno", DAlumno.IdAlumno);
                    cmd.Parameters.AddWithValue("@alumNombre", DAlumno.alumNombre);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Actualizar(Alumno DAlumno)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE tblAlumno SET alumNombre = @alumNombre WHERE IDAlumno = @IDAlumno";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@IDAlumno", DAlumno.IdAlumno);
                    cmd.Parameters.AddWithValue("@alumNombre", DAlumno.alumNombre);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Eliminar(int IdAlumno)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM tblAlumno WHERE IDAlumno = @IDAlumno";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@IDAlumno", IdAlumno);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public Alumno GetByid(int IdAlumno)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM tblAlumno WHERE IDAlumno = @IDAlumno";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {

                    cmd.Parameters.AddWithValue("@IDAlumno", IdAlumno);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        Alumno LAlumno = new Alumno
                        {
                            IdAlumno = Convert.ToInt32(dataReader["@IDAlumno"]),
                            alumNombre = Convert.ToString(dataReader["alumNombre"])
                        };

                        return LAlumno;
                    }
                }
            }
            return null;
        }
    }
}
