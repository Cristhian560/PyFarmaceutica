using PyFarmaceutica.dominio.Login_SignUp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.servicios.interfaces
{
    public interface IServiceLoginSignUp
    {
        Empleado ValidarLogin(Login login);
        bool VerificarEmpleado(Empleado empleado);
        bool CrearUsuario(Login login);
    }
}
