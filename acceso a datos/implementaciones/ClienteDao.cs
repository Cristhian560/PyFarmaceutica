using PyFarmaceutica.acceso_a_datos.interfaces;
using PyFarmaceutica.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.acceso_a_datos.implementaciones
{
    class ClienteDao : IClienteDao
    {
       
        public Cliente TraerCliente(int doc)
        {
            Cliente oCliente = new Cliente();
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=DESKTOP-AOE3FOR\SQLEXPRESS;Initial Catalog = db_farmaceutica2;Integrated Security=True";
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_TRAER_CLIENTE", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@doc", doc);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                oCliente.NombreCliente = reader[0].ToString();
                oCliente.ApellidoCliente = reader[1].ToString();
                cnn.Close();
            }
            catch (Exception)
            {
                 oCliente.NombreCliente = "No existe";
   
            }
            return oCliente;
        }

    }
}
