using PyFarmaceutica.Reportes.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.acceso_a_datos.interfaces
{
    public interface IReporteDao
    {
        DataTable ReporteFacturacion_Mes(Año anio);
        DataTable ReporteCantidadVentas_Suministro();
        DataTable AñosFacturados();
    }
}
