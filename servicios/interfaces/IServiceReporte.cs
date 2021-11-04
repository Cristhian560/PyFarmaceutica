
using PyFarmaceutica.Reportes.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.servicios.interfaces
{
    public interface IServiceReporte
    {
        List<ReporteFacturacionTotal_Mes> GetReporteFacturacionTotal_Mes(Año anio);
        List<ReporteCantidadVentas_Suministro> GetCantidadVentas_Suministros();
        List<Año> GetAños();
    }
}
