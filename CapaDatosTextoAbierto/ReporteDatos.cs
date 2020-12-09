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
    public class ReporteDatos
    {
        public void Insertar(Reporte Dreporte)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "INSERT INTO Reporte (Id_Reporte, Id_cuestionario, pregunta) VALUES (@Id_Reporte, @Id_Cuestionario, @pregunta)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {

                    cmd.Parameters.AddWithValue("@Id_Reporte", Dreporte.Id_reporte);
                    cmd.Parameters.AddWithValue("@Id_Cuestionario", Dreporte.Id_cuestionario);
                    cmd.Parameters.AddWithValue("@pregunta", Dreporte.pregunta);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Actualizar(Reporte Dreporte)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE Reporte SET Id_cuestionario = @Id_Presentacion, pregunta = @pregunta WHERE Id_Reporte = @Id_Reporte";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@Id_Reporte", Dreporte.Id_reporte);
                    cmd.Parameters.AddWithValue("@Id_Cuestionario", Dreporte.Id_cuestionario);
                    cmd.Parameters.AddWithValue("@pregunta", Dreporte.pregunta);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Eliminar(int Id_Reporte)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM Reporte WHERE Id_Reporte = @Id_Reporte";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@Id_Reporte", Id_Reporte);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public Reporte GetByid(int Id_Reporte)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM Reporte WHERE Id_Reporte = @Id_Reporte";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {

                    cmd.Parameters.AddWithValue("@Id_Presentacion", Id_Reporte);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        Reporte Lreporte = new Reporte
                        {
                            Id_reporte = Convert.ToInt32(dataReader["Id_Presentacion"]),
                            Id_cuestionario = Convert.ToInt32(dataReader["Id_Cuestionario"]),
                            pregunta = Convert.ToString(dataReader["pregunta"]),
                        };

                        return Lreporte;
                    }
                }
            }
            return null;
        }
    }
}
