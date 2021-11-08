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

        public bool RegistrarUsuario(Login login)
        {
            SqlTransaction transaccion = null;
            bool flag = true;
            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();

                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_USUARIO", cnn, transaccion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@legajo", login.Usuario);
                cmd.Parameters.AddWithValue("@pass", login.Contrasenia);

                cmd.ExecuteNonQuery();

                transaccion.Commit();
            }
            catch
            {
                transaccion.Rollback();
                flag = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
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

        public DataTable VerificarEmpleado(Empleado empleado)
        {
            SqlCommand cmd = new SqlCommand("SP_VERIFICAR_EMPLEADO", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_legajo", empleado.Legajo);
            cmd.Parameters.AddWithValue("@nom_empleado",empleado.Nombre);
            cmd.Parameters.AddWithValue("@ape_empleado",empleado.Apellido);
            cmd.Parameters.AddWithValue("@email",empleado.Email);

            DataTable tabla = new DataTable();

            cnn.Open();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
    }
}
