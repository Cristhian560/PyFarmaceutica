using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.Reportes.entidades
{
    public class ReporteFacturacionTotal_Mes
    {
        public string Mes { get; set; }
        public int NroFactura { get; set; }
        public DateTime Fecha{ get; set; }
        public double Total { get; set; }
    }
}
