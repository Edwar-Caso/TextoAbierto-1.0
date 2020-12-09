using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosTextoAbierto;
using CapaEntidadesTextoAbierto;

namespace CapaNegocioTextoAbierto
{
    class RespuestaN
    {
        private RespuestaDatos respuestaD = new RespuestaDatos();

        public readonly StringBuilder stringBuilder = new StringBuilder();

        public void Registrar(Respuesta respuesta)
        {
            if (Validar(respuesta))
            {
                if (respuestaD.GetByid(respuesta.Id_respuesta) == null)
                {
                    respuestaD.Insertar(respuesta);
                }
                else
                    respuestaD.Actualizar(respuesta);

            }
        }

        public Respuesta TraerPorId(int Id_respuesta)
        {
            stringBuilder.Clear();

            if (Id_respuesta == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return respuestaD.GetByid(Id_respuesta);
            }
            return null;
        }

        public void Eliminar(int Id_respuesta)
        {
            stringBuilder.Clear();

            if (Id_respuesta == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                respuestaD.Eliminar(Id_respuesta);
            }
        }

        private bool Validar(Respuesta respuesta)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(respuesta.nombre_alumno)) stringBuilder.Append("Ingrese su nombre por favor...");
            if (string.IsNullOrEmpty(respuesta.respuesta)) stringBuilder.Append("Escriba su respuesta por favor...");

            return stringBuilder.Length == 0;
        }
    }
}
