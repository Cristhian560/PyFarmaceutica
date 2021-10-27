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

namespace PyFarmaceutica.Presentacion
{
    public partial class FormSuministrodeprueba : Form
    {
        private IServiceSuministro serviceSuministro;
        public FormSuministrodeprueba()
        {
            InitializeComponent();
            serviceSuministro = new ServiceSuministro();
        }
        private void btnSuministro_Click(object sender, EventArgs e)
        {
            dgvSuministros.DataSource = serviceSuministro.Suministros();
            
        }
    }
}
