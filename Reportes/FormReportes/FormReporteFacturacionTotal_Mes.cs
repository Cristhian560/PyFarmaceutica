
using PyFarmaceutica.Reportes.entidades;
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

namespace PyFarmaceutica.Reportes.FormReportes
{
    public partial class FormReporteFacturacionTotal_Mes : Form
    {
        private IServiceReporte serviceReporte;

        public FormReporteFacturacionTotal_Mes()
        {
            InitializeComponent();
            serviceReporte = new ServiceReporte();
            cboAño.DataSource = serviceReporte.GetAños();
            cboAño.ValueMember = "Anio";
            cboAño.DisplayMember = "Anio";
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Año anio = (Año)cboAño.SelectedItem;
            ReporteFacturacionTotalBindingSource.DataSource = serviceReporte.GetReporteFacturacionTotal_Mes(anio);
            this.reportViewer1.RefreshReport();
        }
    }
}
