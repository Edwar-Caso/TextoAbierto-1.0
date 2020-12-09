using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosTextoAbierto;
using CapaEntidadesTextoAbierto;

namespace CapaNegocioTextoAbierto
{
    class ReporteN
    {
        private ReporteDatos reporteD = new ReporteDatos();

        public readonly StringBuilder stringBuilder = new StringBuilder();

        public void Registrar(Reporte reporte)
        {
            if (Validar(reporte))
            {
                if (reporteD.GetByid(reporte.Id_reporte) == null)
                {
                    reporteD.Insertar(reporte);
                }
                else
                    reporteD.Actualizar(reporte);

            }
        }

        public Reporte TraerPorId(int Id_reporte)
        {
            stringBuilder.Clear();

            if (Id_reporte == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return reporteD.GetByid(Id_reporte);
            }
            return null;
        }

        public void Eliminar(int Id_reporte)
        {
            stringBuilder.Clear();

            if (Id_reporte == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                reporteD.Eliminar(Id_reporte);
            }
        }

        private bool Validar(Reporte reporte)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(reporte.pregunta)) stringBuilder.Append("Ingrese por favor su pregunta...");
            
            return stringBuilder.Length == 0;
        }
    }
}
