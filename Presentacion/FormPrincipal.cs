using PyFarmaceutica.dominio.Login_SignUp;
using PyFarmaceutica.Presentacion;
using PyFarmaceutica.Reportes.FormReportes;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal(Empleado empleado)
        {
            InitializeComponent();
            PersonalizarDiseño();
            CargarDatosEmpleado(empleado);
        }

        private void CargarDatosEmpleado(Empleado empleado)
        {
            lblNombreEmpleado.Text = empleado.Nombre;
            lblApellidoEmpleado.Text = empleado.Apellido;
        }

        private void PersonalizarDiseño()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
            if (panel5.Visible == true)
                panel5.Visible = false;
        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel2);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel3);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnSuministros_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            Form form_suministros = new FormSuministro();
            AbrirForm(form_suministros);
        }
        private Form activeForm = null;
        private void AbrirForm(Form form)
        {
            if (activeForm!=null) 
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            panelPrincipal.Controls.Add(form);
            panelPrincipal.Tag = form;
            form.Show();

        }
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel2);
        }
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel4);
        }
        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel5);
        }
        private void btnTotalFacturacion_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            Form form_total_facturacion = new FormReporteFacturacionTotal_Mes();
            AbrirForm(form_total_facturacion);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnStocks_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            Form form_acerca_de = new FormAcercaDe();
            AbrirForm(form_acerca_de);
        }

        private void btnSunistrosVendidos_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            Form form_cantidad_ventas_suministros = new FormReporteCantidadVentas_Suministro();
            AbrirForm(form_cantidad_ventas_suministros);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            Form form_factura = new FormFactura();
            AbrirForm(form_factura);
        }
    }
}
