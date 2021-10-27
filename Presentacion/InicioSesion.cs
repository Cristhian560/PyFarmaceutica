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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
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
            if (ComprobarUsuario())
            {
                FormPrincipal form_principal = new FormPrincipal();
                form_principal.IdEmpleado = 5;
                form_principal.Show();
            }
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
    }
}
