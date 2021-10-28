using PyFarmaceutica.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.servicios.interfaces
{
    public interface IServiceSuministro
    {
        List<Suministro> Suministros();
        List<TipoSuministro> TipoSuministros();
        bool Insert(Suministro suministro);
        bool Delete(int id);
        bool Update(Suministro suministro);
    }
}
