using PyFarmaceutica.dominio.Login_SignUp;
using PyFarmaceutica.servicios.implementaciones;
using PyFarmaceutica.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyFarmaceutica
{
    public partial class FormLogin : Form
    {
        private IServiceLoginSignUp serviceLoginSignUp;
        public FormLogin()
        {
            InitializeComponent();
            serviceLoginSignUp = new ServiceLoginSignUp();
        }
        private bool ComprobarUsuario()
        {
            if (txtUsuario.Text == null || txtUsuario.Text == "")
            {
                MessageBox.Show("CAMPO USUARIO VACIO !!!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool SeguridadContraseña(string contraseña)
        {
            bool mayusculas = false;
            bool minusculas = false;
            bool numero = false;
            bool caracter = false;
            int tamaño_contraseña = 6;
            if (contraseña.Length>=tamaño_contraseña)
            {
                for (int i = 0; i < contraseña.Length; i++)
                {
                    if (Char.IsUpper(contraseña, i))
                    {
                        mayusculas = true;
                    }
                    else if (Char.IsLower(contraseña, i))
                    {
                        minusculas = true;
                    }
                    else if (Char.IsDigit(contraseña, i))
                    {
                        numero = true;
                    }
                    else
                    {
                        caracter = true;
                    }
                }
            }
            if(mayusculas && minusculas && numero && caracter)
            {
                return true;
            }
            return false;
        }
        private void InicioSesion_Load(object sender, EventArgs e)
        {
            btnIniciarSesion.Enabled = false;
            btnRegistrar.Enabled = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (ComprobarUsuario())//falta comprobar que el usuario sea int
            {
                Login login = new Login()
                {
                    Usuario = Convert.ToInt32(txtUsuario.Text),
                    Contrasenia = txtContraseña.Text.ToString()
                };
                Empleado empleado = serviceLoginSignUp.ValidarLogin(login);
                if (empleado.Legajo == 0000)
                {
                    lblAviso.Visible = true;
                }
                else
                {
                    FormPrincipal form_principal = new FormPrincipal(empleado);
                    LimpiarCampos(true);
                    lblAviso.Visible = false;
                    form_principal.ShowDialog();
                }
            }
        }
        private void LimpiarCampos(bool v)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (SeguridadContraseña(txtContraseña.Text) && ComprobarUsuario())
            {
                btnIniciarSesion.Enabled = true;
            }
            else
            {
                btnIniciarSesion.Enabled = false;
            }
        }
        private void linkRegistarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            X(false);
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //falta verificaciones de los texBox
            //falta verificar si el empleado que se quiere registrar ya esta registrado o no(verificar con el legajo en la tabla login_f)
            try
            {
                Empleado empleado = new Empleado()
                {
                    Legajo = Convert.ToInt32(txtUsuarioR.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtCorreo.Text
                };

                if (serviceLoginSignUp.VerificarEmpleado(empleado))
                {
                    Login login = new Login()
                    {
                        Usuario = Convert.ToInt32(txtUsuarioR.Text),
                        Contrasenia = txtContrasenia.Text
                    };
                    if (serviceLoginSignUp.CrearUsuario(login))
                    {
                        MessageBox.Show("REGISTRO EXITOSO !!");
                    }
                }
                X(true);
            }
            catch (Exception)
            {
                MessageBox.Show("Datos ingresados incorrectos");
            }
        }
        private void X(bool v)
        {
            panel2.Visible = v;
            if (!v)
            {
                panelLogin.BackgroundColor = Color.Black;
            }
            else
            {
                panelLogin.BackgroundColor = Color.FromArgb(64, 64, 64);
            }
        }
        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (SeguridadContraseña(txtContrasenia.Text))
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }
    }
}
