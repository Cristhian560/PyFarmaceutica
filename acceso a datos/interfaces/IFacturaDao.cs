using PyFarmaceutica.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.acceso_a_datos.interfaces
{
    interface IFacturaDao
    {
        bool Alta(Factura oFactura);

        //bool Delete(int nro);
        int ProximaFactura();
        DataTable ObtenerSuministros();
        DataTable ObtenerObrasSociales();
        
        DataTable ObtenerSucursales();
        DataTable ObtenerMediosPago();

       
        Factura ObtenerFtxId(int nro);

    }
}
