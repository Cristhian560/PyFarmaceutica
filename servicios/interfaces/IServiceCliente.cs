using PyFarmaceutica.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.servicios.interfaces
{
    interface IServiceCliente
    {
        Cliente TraerCliente(int doc);
    }
}
