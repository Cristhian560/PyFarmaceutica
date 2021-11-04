using PyFarmaceutica.acceso_a_datos.implementaciones;
using PyFarmaceutica.acceso_a_datos.interfaces;
using PyFarmaceutica.dominio;
using PyFarmaceutica.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.servicios.implementaciones
{
    class ServiceFactura:IServiceFactura
    {
        private IFacturaDao dao;
        public ServiceFactura()
        {
            dao = new FacturaDao();
        }


        public int ProximaFactura()
        {
            return dao.ProximaFactura();
        }

        public DataTable ObtenerSuministros()
        {
            return dao.ObtenerSuministros();
        }
        public DataTable ObtenerObrasSociales()
        {
            return dao.ObtenerObrasSociales();
        }
       
       

        public DataTable ObtenerSucursales()
        {
            return dao.ObtenerSucursales();
        }
        public DataTable ObtenerMediosPago()
        {
            return dao.ObtenerMediosPago();
        }

        public bool Alta(Factura oFactura)
        {
            return dao.Alta(oFactura);
        }
      
        public Factura ObtenerFtxId(int nro)
        {
            throw new NotImplementedException();
        }
    }
}
