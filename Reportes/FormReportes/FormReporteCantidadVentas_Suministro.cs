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
    public partial class FormReporteCantidadVentas_Suministro : Form
    {
        private IServiceReporte serviceReporte;
        public FormReporteCantidadVentas_Suministro()
        {
            InitializeComponent();
            serviceReporte = new ServiceReporte();
        }

        private void FormReporteCantidadVentas_Suministro_Load(object sender, EventArgs e)
        {
            ReporteCantidadVentas_SuministroBindingSource.DataSource = serviceReporte.GetCantidadVentas_Suministros();
            this.reportViewer1.RefreshReport();
        }
    }
}
