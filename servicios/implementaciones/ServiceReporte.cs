
using PyFarmaceutica.acceso_a_datos.implementaciones;
using PyFarmaceutica.acceso_a_datos.interfaces;
using PyFarmaceutica.Reportes;
using PyFarmaceutica.Reportes.entidades;
using PyFarmaceutica.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.servicios.implementaciones
{
    public class ServiceReporte : IServiceReporte
    {
        private IReporteDao reporteDao;
        public ServiceReporte()
        {
            reporteDao = new ReporteDao();
        }

        public List<Año> GetAños()
        {
            List<Año> Lista_obj_año = new List<Año>();
            foreach (DataRow item in reporteDao.AñosFacturados().Rows)
            {
                Año obj_año = new Año()
                {
                    Anio = Convert.ToInt32(item.ItemArray[0])
                };
                Lista_obj_año.Add(obj_año);
            }
            return Lista_obj_año;
        }
        public List<ReporteCantidadVentas_Suministro> GetCantidadVentas_Suministros()
        {
            List<ReporteCantidadVentas_Suministro> Lista_obj_cantidad_ventas_suministro = new List<ReporteCantidadVentas_Suministro>();
            foreach (DataRow item in reporteDao.ReporteCantidadVentas_Suministro().Rows)
            {
                ReporteCantidadVentas_Suministro obj_cantidad_ventas_suministro = new ReporteCantidadVentas_Suministro()
                {
                    IdSuministro = Convert.ToInt32(item.ItemArray[0]),
                    Suministro= item.ItemArray[1].ToString(),
                    Cantidad= Convert.ToInt32(item.ItemArray[2]),
                    Monto = Convert.ToInt32(item.ItemArray[3])
                };
                Lista_obj_cantidad_ventas_suministro.Add(obj_cantidad_ventas_suministro);
            }
            return Lista_obj_cantidad_ventas_suministro;
        }

        public List<ReporteFacturacionTotal_Mes> GetReporteFacturacionTotal_Mes(Año anio)
        {
            List<ReporteFacturacionTotal_Mes> Lista_obj_facturacion_mes = new List<ReporteFacturacionTotal_Mes>();
            foreach (DataRow item in reporteDao.ReporteFacturacion_Mes(anio).Rows)
            {
                ReporteFacturacionTotal_Mes obj_facturacion_mes = new ReporteFacturacionTotal_Mes()
                {
                    Mes = item.ItemArray[0].ToString(),
                    NroFactura = Convert.ToInt32(item.ItemArray[1]),
                    Fecha= Convert.ToDateTime(item.ItemArray[2].ToString()),
                    Total=Convert.ToDouble(item.ItemArray[3])
                };
                Lista_obj_facturacion_mes.Add(obj_facturacion_mes);
            }
            return Lista_obj_facturacion_mes;
        }
    }
}
