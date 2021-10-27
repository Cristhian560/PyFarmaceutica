using PyFarmaceutica.Presentacion;
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
        public int IdEmpleado { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseño();
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
                this.Dispose();
            }
        }
        private void btnSuministros_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            Form formSoporte = new FormSuministro();
            AbrirForm(formSoporte);
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            HideSubMenu();
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
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            HideSubMenu();
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
            Form form_total_facturacion = new FormTotalFacturacion();
            AbrirForm(form_total_facturacion);
        }
    }
}
