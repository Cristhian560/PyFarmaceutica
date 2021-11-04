using PyFarmaceutica.acceso_a_datos.interfaces;
using PyFarmaceutica.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyFarmaceutica.acceso_a_datos.implementaciones
{
    class FacturaDao : IFacturaDao
    {


        public bool Alta(Factura oFactura)
        {
            SqlTransaction t=null;
            bool resultado = true;
            SqlConnection cnn = new SqlConnection();
          

            try
            {
                cnn.ConnectionString = @"Data Source=DESKTOP-AOE3FOR\SQLEXPRESS;Initial Catalog = db_farmaceutica2;Integrated Security=True";
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmdM = new SqlCommand("PA_INSERTAR_FACTURA", cnn,t);
                cmdM.CommandType = CommandType.StoredProcedure;

                cmdM.Parameters.AddWithValue("@nro", oFactura.NroFactura);
                cmdM.Parameters.AddWithValue("@fecha_emision", oFactura.FechaEmision);
                cmdM.Parameters.AddWithValue("@formaPago", oFactura.MedioPago);
                cmdM.Parameters.AddWithValue("@cliente", oFactura.Cliente);
                cmdM.Parameters.AddWithValue("@obraSocial", oFactura.ObraSocial);
                cmdM.Parameters.AddWithValue("@sucursal", oFactura.Sucursal);

                

                cmdM.ExecuteNonQuery();
                
                

                int nro =oFactura.NroFactura;
                int cDetalles = 0;
                foreach (DetalleFactura det in oFactura.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand("PA_INSERTAR_DETALLES_FACTURA", cnn,t);
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.Parameters.AddWithValue("@nro", nro);
                    cmdDet.Parameters.AddWithValue("@detalle", cDetalles);
                    cmdDet.Parameters.AddWithValue("@idSuministro", det.Suministro.IdSuministro);
                    cmdDet.Parameters.AddWithValue("@cobertura", det.Cobertura);
                    cmdDet.Parameters.AddWithValue("@precio", det.Suministro.Precio);
                    cmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    cmdDet.ExecuteNonQuery();
                    cDetalles++;
                }
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                resultado = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return resultado;

        }

        public Factura ObtenerFtxId(int nro)
        {
            throw new NotImplementedException();
        }

        public DataTable ObtenerMediosPago()
        {
            DataTable table;
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=DESKTOP-AOE3FOR\SQLEXPRESS;Initial Catalog = db_farmaceutica2;Integrated Security=True";
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_CONSULTAR_MEDIOS_DE_PAGO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                table = new DataTable();
                table.Load(cmd.ExecuteReader());
                cnn.Close();

            }
            catch (Exception)
            {
                table = null;
            }
            return table;
        }

        public DataTable ObtenerObrasSociales()
        {
            DataTable table;
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=DESKTOP-AOE3FOR\SQLEXPRESS;Initial Catalog = db_farmaceutica2;Integrated Security=True";
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_CONSULTAR_OBRA_SOCIAL", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                table = new DataTable();
                table.Load(cmd.ExecuteReader());
                cnn.Close();

            }
            catch (Exception)
            {
                table = null;
            }
            return table;
        }

        public DataTable ObtenerSucursales()
        {
            DataTable table;
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=DESKTOP-AOE3FOR\SQLEXPRESS;Initial Catalog = db_farmaceutica2;Integrated Security=True";
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_CONSULTAR_SUCURSAL", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                table = new DataTable();
                table.Load(cmd.ExecuteReader());
                cnn.Close();

            }
            catch (Exception)
            {
                table = null;
            }
            return table;
        }

        public DataTable ObtenerSuministros()
        {
            DataTable table;
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=DESKTOP-AOE3FOR\SQLEXPRESS;Initial Catalog = db_farmaceutica2;Integrated Security=True";
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_CONSULTAR_SUMINISTROS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                table = new DataTable();
                table.Load(cmd.ExecuteReader());
                cnn.Close();

            }
            catch (Exception)
            {
                table = null;
            }
            return table;

        }

        public int ProximaFactura()
        {
            int nro = 0;
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=DESKTOP-AOE3FOR\SQLEXPRESS;Initial Catalog = db_farmaceutica2;Integrated Security=True";
                cnn.Open();
                SqlCommand cmd = new
                SqlCommand("PA_PROXIMA_FACTURA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                nro = Convert.ToInt32(param.Value);
                cnn.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nro;

        }

       
    }

}

   

