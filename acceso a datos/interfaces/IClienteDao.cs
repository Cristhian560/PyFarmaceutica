using PyFarmaceutica.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.acceso_a_datos.interfaces
{
    interface IClienteDao
    {
        Cliente TraerCliente(int doc);
    }
}
