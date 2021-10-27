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
    public class SuministroDao : ISuministroDao
    {
        private string CadenaConexion;
        private SqlConnection cnn;
        public SuministroDao()
        {
            CadenaConexion = HelperDao.Instancia().CadenaConeccion();
            cnn = new SqlConnection(CadenaConexion);
        }
        public DataTable Suministros()
        {
            SqlCommand cmd = new SqlCommand("SP_CONSULTAR_SUMINISTROS",cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            
            cnn.Open();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
    }
}
