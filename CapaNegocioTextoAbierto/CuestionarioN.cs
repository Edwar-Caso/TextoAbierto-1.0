using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CapaDatosTextoAbierto;
using CapaEntidadesTextoAbierto;

namespace CapaNegocioTextoAbierto
{
    /*public class CuestionarioN
    {
        private CuestionarioDatos cuestionarioD = new CuestionarioDatos();
       
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public void Registrar(Cuestionario cuestionario)
        {
            if (Validar(cuestionario))
            {
                if (cuestionarioD.GetByid(cuestionario.Id_Cuestionario) == null)
                {
                    cuestionarioD.Insertar(cuestionario);
                }
                else
                    cuestionarioD.Actualizar(cuestionario);

            }
        }*/

       /* public Cuestionario TraerPorId(int Id_Cuestionario)
        {
            stringBuilder.Clear();

            if (Id_Cuestionario == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return cuestionarioD.GetByid(Id_Cuestionario);
            }
            return null;
        }*/

       /* public void Eliminar(int Id_Cuestionario)
        {
            stringBuilder.Clear();

            if (Id_Cuestionario == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                cuestionarioD.Eliminar(Id_Cuestionario);
            }
        }

        private bool Validar(Cuestionario cuestionario)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(cuestionario.pregunta)) stringBuilder.Append("Ingrese por favor su pregunta...");
            if (string.IsNullOrEmpty(cuestionario.descripcion)) stringBuilder.Append("El campo Descripción es obligatorio");

            return stringBuilder.Length == 0;
        }
    }*/
}