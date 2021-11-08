using PyFarmaceutica.acceso_a_datos.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.acceso_a_datos.implementaciones
{
    public class ReporteStockDao : IReporteStockDao
    {
        private SqlConnection cnn;
        public ReporteStockDao()
        {
            cnn = new SqlConnection(HelperDao.Instancia().CadenaConeccion());
        }
        public DataTable ReporteStocks()
        {
            SqlCommand cmd = new SqlCommand("SP_CONSULTAR_STOCKS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();

            cnn.Open();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
    }
}
