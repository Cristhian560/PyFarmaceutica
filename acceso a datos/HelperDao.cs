using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica
{
    class HelperDao
    {
        private static HelperDao instancia;
        private string CadenaConexion;
        private HelperDao()
        {
            CadenaConexion = @"Data Source=DESKTOP-AOE3FOR\SQLEXPRESS;Initial Catalog = db_farmaceutica;Integrated Security=True";
        }
        public static HelperDao Instancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }
        public string CadenaConeccion()
        {
            return CadenaConexion;
        }
    }
}
