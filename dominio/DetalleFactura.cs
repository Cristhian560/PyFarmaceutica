using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.dominio
{
    class DetalleFactura
    {
       

        public Suministro Suministro { get; set; }
        public int Cantidad { get; set; }

        public string Cobertura { get; set; }



        public DetalleFactura(Suministro suministro, int cantidad, string cobertura)
        {
            Suministro = suministro;
            Cantidad = cantidad;
            Cobertura = cobertura;
          
        }

     

        public double CalcularSubtotal()
        {
            return Suministro.Precio * Cantidad;
        }
    }
}
