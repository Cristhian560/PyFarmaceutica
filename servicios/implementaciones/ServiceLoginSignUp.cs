using PyFarmaceutica.acceso_a_datos.implementaciones;
using PyFarmaceutica.acceso_a_datos.interfaces;
using PyFarmaceutica.dominio.Login_SignUp;
using PyFarmaceutica.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.servicios.implementaciones
{
    public class ServiceLoginSignUp : IServiceLoginSignUp
    {
        private ILoginSignUpDao loginSingUpDao;

        public ServiceLoginSignUp()
        {
            loginSingUpDao = new LoginSignUpDao();
        }

        public bool CrearUsuario(Login login)
        {
            return loginSingUpDao.RegistrarUsuario(login);
        }

        public Empleado ValidarLogin(Login login)
        {
            var tabla = loginSingUpDao.ValidarLogin(login);

            Empleado empleado = new Empleado();

            if (tabla.Rows.Count==0)
            {
                empleado.Legajo = 0000;
            }
            else
            {
                foreach (DataRow item in tabla.Rows)
                {
                    empleado.Legajo = Convert.ToInt32(item.ItemArray[3]);
                    empleado.Nombre = item.ItemArray[4].ToString();
                    empleado.Apellido = item.ItemArray[5].ToString();
                    empleado.Email = item.ItemArray[6].ToString();
                }
            }
            return empleado;
        }

        public bool VerificarEmpleado(Empleado empleado)
        {
            var tabla = loginSingUpDao.VerificarEmpleado(empleado);

            if (tabla.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
