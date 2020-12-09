using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosTextoAbierto;
using CapaEntidadesTextoAbierto;

namespace CapaNegocioTextoAbierto
{
    class PresentacionN
    {
        private  PresentacionDatos presentacionD = new PresentacionDatos();

        public readonly StringBuilder stringBuilder = new StringBuilder();

        public void Registrar(Presentacion presentacion)
        {
            if (Validar(presentacion))
            {
                if (presentacionD.GetByid(presentacion.Id_presentacion) == null)
                {
                    presentacionD.Insertar(presentacion);
                }
                else
                    presentacionD.Actualizar(presentacion);

            }
        }

        public Presentacion TraerPorId(int Id_Presentacion)
        {
            stringBuilder.Clear();

            if (Id_Presentacion == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return presentacionD.GetByid(Id_Presentacion);
            }
            return null;
        }

        public void Eliminar(int Id_Presentacion)
        {
            stringBuilder.Clear();

            if (Id_Presentacion == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                presentacionD.Eliminar(Id_Presentacion);
            }
        }

        private bool Validar(Presentacion presentacion)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(presentacion.pregunta)) stringBuilder.Append("Ingrese por favor su pregunta...");
            if (string.IsNullOrEmpty(presentacion.descripcion)) stringBuilder.Append("El campo Descripción es obligatorio");

            return stringBuilder.Length == 0;
        }
    }
}
