using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.dominio
{
    class Factura
    {
        public int NroFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaBaja  { get; set; }
        public int MedioPago { get; set; }
        public int Cliente { get; set; }
        public int ObraSocial { get; set; }
        public int Sucursal { get; set; }
        public List<DetalleFactura> Detalles { get; set; }

        public Factura(int nroFt,DateTime fchaEmision,int medioPago, int clte,int os,int suc)
        {
            Detalles = new List<DetalleFactura>();
            NroFactura = nroFt;
            FechaEmision = fchaEmision;
            MedioPago = medioPago;
            Cliente = clte;
            ObraSocial = os;
            Sucursal = suc;
        }

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }

        public void AgregarDetalle(DetalleFactura detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int posicion)
        {
            Detalles.RemoveAt(posicion);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetalleFactura item in Detalles)
            {
                total += item.CalcularSubtotal();
            }
            return total;
        }




    }
}
