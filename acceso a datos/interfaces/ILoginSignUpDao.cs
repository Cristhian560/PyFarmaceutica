using PyFarmaceutica.dominio.Login_SignUp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.acceso_a_datos.interfaces
{
    public interface ILoginSignUpDao
    {
        DataTable ValidarLogin(Login login);
        DataTable VerificarEmpleado(Empleado empleado);
        bool RegistrarUsuario(Login login);
    }
}
