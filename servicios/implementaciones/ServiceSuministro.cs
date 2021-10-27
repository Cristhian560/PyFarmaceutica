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
    public class ServiceSuministro : IServiceSuministro
    {
        ISuministroDao suministroDao;
        public ServiceSuministro()
        {
            suministroDao = new SuministroDao();
        }
        public List<Suministro> Suministros()
        {
            List<Suministro> lista_suministros = new List<Suministro>();
            foreach (DataRow item in suministroDao.Suministros().Rows)
            {
                Suministro suministro = new Suministro()
                {
                    IdSuministro = Convert.ToInt32(item.ItemArray[0]),
                    Nombre = item.ItemArray[1].ToString(),
                    VentaLibre = item.ItemArray[2].ToString(),
                    IdTipoSuministro = Convert.ToInt32(item.ItemArray[3]),
                    Precio = Convert.ToDouble(item.ItemArray[4]),
                    Descripcion = item.ItemArray[5].ToString()
                };
                lista_suministros.Add(suministro);
            }
            return lista_suministros;
        }
    }
}
