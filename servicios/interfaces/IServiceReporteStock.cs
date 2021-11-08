using PyFarmaceutica.Reportes.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.servicios.interfaces
{
    public interface IServiceReporteStock
    {
        List<Stock> GetStocks();
    }
}
