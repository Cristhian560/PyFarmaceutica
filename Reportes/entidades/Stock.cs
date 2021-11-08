using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.Reportes.entidades
{
    public class Stock
    {
        public int IdStock { get; set; }
        public int IdSuministro { get; set; }
        public string Suministro { get; set; }
        public string Descripcion { get; set; }
        public int StockDisponible { get; set; }
        public int StockMinimo { get; set; }
    }
}
