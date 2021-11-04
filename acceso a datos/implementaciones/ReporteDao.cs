using PyFarmaceutica.acceso_a_datos.interfaces;
using PyFarmaceutica.Reportes.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.acceso_a_datos.implementaciones
{
    public class ReporteDao : IReporteDao
    {
        private string CadenaConexion;
        private SqlConnection cnn;
        public ReporteDao()
        {
            CadenaConexion = HelperDao.Instancia().CadenaConeccion();
            cnn = new SqlConnection(CadenaConexion);
        }

        public DataTable AñosFacturados()
        {
            SqlCommand cmd = new SqlCommand("SP_CONSULTA_AÑOS_FACTURADOS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();

            cnn.Open();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        public DataTable ReporteCantidadVentas_Suministro()
        {
            SqlCommand cmd = new SqlCommand("SP_REPORTE_CANTIDAD_VENTAS_SUMINISTRO", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();

            cnn.Open();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
        public DataTable ReporteFacturacion_Mes(Año anio)
        {
            SqlCommand cmd = new SqlCommand("SP_REPORTE_FACTURACION_MES", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("anio",anio.Anio);

            DataTable tabla = new DataTable();

            cnn.Open();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
    }
}
