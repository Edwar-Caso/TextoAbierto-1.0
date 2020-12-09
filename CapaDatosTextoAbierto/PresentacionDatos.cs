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
    public class PresentacionDatos
    {
        public void Insertar(Presentacion Dpresentacion)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "INSERT INTO Presentacion (Id_Presentacion, Id_cuestionario, pregunta, descripcion, imagen) VALUES (@Id_Presentacion, @Id_Cuestionario, @pregunta, @descripcion, @imagen)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {

                    cmd.Parameters.AddWithValue("@Id_Presentacion", Dpresentacion.Id_presentacion);
                    cmd.Parameters.AddWithValue("@Id_Cuestionario", Dpresentacion.Id_cuestionario);
                    cmd.Parameters.AddWithValue("@pregunta", Dpresentacion.pregunta);
                    cmd.Parameters.AddWithValue("@descripcion", Dpresentacion.descripcion);
                    cmd.Parameters.AddWithValue("@imagen", Dpresentacion.imagen);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Actualizar(Presentacion Dpresentacion)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE Presentacion SET Id_cuestionario = @Id_Cuestionario, pregunta = @pregunta, Descripcion = @descripcion, imagen = @imagen WHERE Id_Presentacion = @Id_Presentacion";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@Id_Presentacion", Dpresentacion.Id_presentacion);
                    cmd.Parameters.AddWithValue("@Id_Cuestionario", Dpresentacion.Id_cuestionario);
                    cmd.Parameters.AddWithValue("@pregunta", Dpresentacion.pregunta);
                    cmd.Parameters.AddWithValue("@descripcion", Dpresentacion.descripcion);
                    cmd.Parameters.AddWithValue("@imagen", Dpresentacion.imagen);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Eliminar(int Id_Presentacion)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM Presentacion WHERE Id_Presentacion = @Id_Presentacion";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@Id_Presentacion", Id_Presentacion);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public Presentacion GetByid(int Id_Presentacion)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM Presentacion WHERE Id_Presentacion = @Id_Presentacion";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {

                    cmd.Parameters.AddWithValue("@Id_Presentacion", Id_Presentacion);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        Presentacion Lpresentacion = new Presentacion
                        {
                            Id_presentacion = Convert.ToInt32(dataReader["Id_Presentacion"]),
                            Id_cuestionario = Convert.ToInt32(dataReader["Id_Cuestionario"]),
                            pregunta = Convert.ToString(dataReader["pregunta"]),
                            descripcion = Convert.ToString(dataReader["descripcion"]),
                            imagen = Convert.ToByte(dataReader["Precio"])
                        };

                        return Lpresentacion;
                    }
                }
            }
            return null;
        }
    }
}
