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
    public partial class FormReporteStock : Form
    {
        private IServiceReporteStock serviceReporteStock;
        public FormReporteStock()
        {
            InitializeComponent();
            serviceReporteStock = new ServiceReporteStock();
        }

        private void FormReporteStock_Load(object sender, EventArgs e)
        {
            StockBindingSource.DataSource = serviceReporteStock.GetStocks();
            this.reportViewer1.RefreshReport();
        }
    }
}
