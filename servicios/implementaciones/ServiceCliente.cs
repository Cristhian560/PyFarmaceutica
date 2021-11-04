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
    class ServiceCliente:IServiceCliente
    {
        private IClienteDao dao;

        public ServiceCliente()
        {
            dao = new ClienteDao();
        }

        public Cliente TraerCliente(int doc)
        {
            return dao.TraerCliente(doc);
        }
    }
}
