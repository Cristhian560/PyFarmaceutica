using PyFarmaceutica.acceso_a_datos.implementaciones;
using PyFarmaceutica.acceso_a_datos.interfaces;
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
    public class ServiceReporteStock : IServiceReporteStock
    {
        private IReporteStockDao reporteSockDao;
        public ServiceReporteStock()
        {
            reporteSockDao = new ReporteStockDao();
        }
        public List<Stock> GetStocks()
        {
            List<Stock> Lista_obj_stock = new List<Stock>();
            foreach (DataRow item in reporteSockDao.ReporteStocks().Rows)
            {
                Stock obj_stock = new Stock()
                {
                    IdStock = Convert.ToInt32(item.ItemArray[0]),
                    IdSuministro = Convert.ToInt32(item.ItemArray[1]),
                    Suministro = item.ItemArray[2].ToString(),
                    Descripcion = item.ItemArray[3].ToString(),
                    StockDisponible = Convert.ToInt32(item.ItemArray[4]),
                    StockMinimo = Convert.ToInt32(item.ItemArray[5])
                };
                Lista_obj_stock.Add(obj_stock);
            }
            return Lista_obj_stock;
        }
    }
}
