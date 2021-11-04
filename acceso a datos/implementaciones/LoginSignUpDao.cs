using PyFarmaceutica.acceso_a_datos.interfaces;
using PyFarmaceutica.dominio.Login_SignUp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.acceso_a_datos.implementaciones
{
    public class LoginSignUpDao: ILoginSignUpDao
    {
        private string CadenaConexion;
        private SqlConnection cnn;
        public LoginSignUpDao()
        {
            CadenaConexion = HelperDao.Instancia().CadenaConeccion();
            cnn = new SqlConnection(CadenaConexion);
        }
        public DataTable ValidarLogin(Login login)
        {
            SqlCommand cmd = new SqlCommand("SP_VALIDAR_LOGIN", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usuario", login.Usuario);
            cmd.Parameters.AddWithValue("@pass", login.Contrasenia);

            DataTable tabla = new DataTable();

            cnn.Open();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
    }
}
