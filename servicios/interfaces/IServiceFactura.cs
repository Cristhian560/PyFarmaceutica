using PyFarmaceutica.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.servicios.interfaces
{
    interface IServiceFactura
    {
        DataTable ObtenerSuministros();
        DataTable ObtenerObrasSociales();
        DataTable ObtenerSucursales();
        DataTable ObtenerMediosPago();

        bool Alta(Factura oFactura);
        int ProximaFactura();
        Factura ObtenerFtxId(int nro);

    }
}
