using PyFarmaceutica.dominio;
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
    public partial class FormFactura : Form
    {

        private IServiceFactura sFactura;
        private IServiceCliente sCliente;
        Cliente oCliente = new Cliente();
        Factura oFactura = new Factura();


        public FormFactura()
        {
            InitializeComponent(); 
            sFactura = new ServiceFactura();
            sCliente = new ServiceCliente();
        }

        private void CargarSuministros()
        {
            DataTable table = sFactura.ObtenerSuministros();
            if (table != null)
            {
                cboSuministros.DataSource = table;
                cboSuministros.ValueMember = table.Columns[0].ColumnName;
                cboSuministros.DisplayMember = table.Columns[1].ColumnName;
            }
        }

      
        private void TraerCliente(int doc)
        {
            Cliente oCliente = sCliente.TraerCliente(doc);

            if (oCliente.NombreCliente=="No existe")
            {
                MessageBox.Show("Debe dar de alta al Cliente", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtCliente.Text = oCliente.NombreCliente+" "+oCliente.ApellidoCliente;
            
        }


        private void CargarSucursales()
        {
            DataTable table = sFactura.ObtenerSucursales();
            if (table != null)
            {
                cboSucursal.DataSource = table;
                cboSucursal.ValueMember = table.Columns[0].ColumnName;
                cboSucursal.DisplayMember = table.Columns[1].ColumnName;
            }
        }

        private void CargarMediosPago()
        {
            DataTable table = sFactura.ObtenerMediosPago();
            if (table != null)
            {
                cboMedioPago.DataSource = table;
                cboMedioPago.ValueMember = table.Columns[0].ColumnName;
                cboMedioPago.DisplayMember = table.Columns[1].ColumnName;
            }
        }

        private void CargarObrasSociales()
        {
            DataTable table = sFactura.ObtenerObrasSociales();
            if (table != null)
            {
                cboObraSocial.DataSource = table;
                cboObraSocial.ValueMember = table.Columns[0].ColumnName;
                cboObraSocial.DisplayMember = table.Columns[1].ColumnName;
            }
        }

        private void ProximaFactura()
        {
            int next = sFactura.ProximaFactura();
            lblFactura.Text = "Factura N°: " + next.ToString();
        }

        private void CalcularTotales()
        {
            lblTotal.Text = "Total: $" + oFactura.CalcularTotal().ToString();
            lblSubtotal.Text = "Subtotal: $" + oFactura.CalcularTotal().ToString();
        }


        private void FormFactura_Load(object sender, EventArgs e)
        {
            CargarSuministros();
            CargarMediosPago();
            CargarObrasSociales();
            CargarSucursales();
            ProximaFactura();
           
            cboMedioPago.SelectedIndex = -1;
            cboObraSocial.SelectedIndex = -1;
            cboSucursal.SelectedIndex = -1;
            cboSuministros.SelectedIndex = -1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                cboMedioPago.SelectedIndex = -1;
                cboObraSocial.SelectedIndex = -1;
                cboSucursal.SelectedIndex = -1;
                dgvFactura.Rows.Clear();
 
            }
            else
            {
                return;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvFactura.Rows.Count == 0)
            {
                MessageBox.Show("Debe insertar al menos un detalle...", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            oFactura.NroFactura = sFactura.ProximaFactura();
            oFactura.FechaEmision = Convert.ToDateTime(dtpFechaEmision.Text);
            oFactura.MedioPago = cboMedioPago.SelectedIndex;
            oFactura.ObraSocial = cboObraSocial.SelectedIndex;
            oFactura.Sucursal = cboSucursal.SelectedIndex;
            
            
            if (sFactura.Alta(oFactura))
            {

                MessageBox.Show("La factura se guardo exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error la factura no se guardo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
         
            if (cboMedioPago.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un medio de pago", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            if (cboObraSocial.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar una Obra Social", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboSucursal.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar una Sucursal", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboSuministros.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe agregar un ítem", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

            DataRowView item = (DataRowView)cboSuministros.SelectedItem;
            int sumni = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            int pre = Convert.ToInt32(item.Row.ItemArray[4]);
            int cant = Convert.ToInt32(nudCantidad.Value);
            string cob;
            if (rbSi.Checked == true)
            {
                 cob = "S";
            }
            else  cob = "N";

            Suministro s = new Suministro(sumni,nom, pre);

            DetalleFactura d = new DetalleFactura(s, cant,cob);
            oFactura.AgregarDetalle(d);
            dgvFactura.Rows.Add(new object[] { sumni, nom, pre, cant, cob });

            CalcularTotales();

        }

        private void btnValidarCliente_Click(object sender, EventArgs e)
        {
            TraerCliente(Convert.ToInt32(txtDocumento.Text));
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (dgvFactura.CurrentCell.ColumnIndex == 5)
                {
                    oFactura.QuitarDetalle(dgvFactura.CurrentRow.Index);
                    dgvFactura.Rows.Remove(dgvFactura.CurrentRow);
                    CalcularTotales();
                }
            
        }
    }
}
