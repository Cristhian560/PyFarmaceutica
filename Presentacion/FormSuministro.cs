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
    public partial class FormSuministro : Form
    {
        private IServiceSuministro serviceSuministro;
        List<Suministro> lista_suministros;
        public FormSuministro()
        {
            InitializeComponent();
            serviceSuministro = new ServiceSuministro();
            CargarlistaDB();
        }
        private void CargarlistaDB()
        {
            lista_suministros = serviceSuministro.Suministros();
        }
        private void FormSuministro_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            btnGuardarCambios.Enabled = false;
            btnCancelar.Enabled = false;
            cboTipo.DataSource = serviceSuministro.TipoSuministros();
            cboTipo.ValueMember = "IdTipoSuministro";
            cboTipo.DisplayMember = "NombreTipoSuministro";
        }
        private void dgvSuministros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSuministros.CurrentCell.ColumnIndex == 1)
            {
                lista_suministros.RemoveAt(dgvSuministros.CurrentRow.Index);
                dgvSuministros.Rows.Remove(dgvSuministros.CurrentRow);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ComprobarCampos())
            {
                MessageBox.Show("CAMPO VACIO");
            }
            else
            {
                foreach (Suministro item in lista_suministros)
                {
                    if (item.IdSuministro == Convert.ToInt32(txtCodigo.Text))
                    {
                        MessageBox.Show("El CODIGO INGRESADO YA EXISTE");
                        return;
                    }
                }

                lista_suministros.Add(ConstruirObjeto());
                serviceSuministro.Insert(ConstruirObjeto());
                CargarlistaDB();
                CargarGrilla();
            }
        }

        private bool ComprobarCampos()
        {
            if(txtCodigo.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CargarGrilla()
        {
            foreach (Suministro s in lista_suministros)
            {
                dgvSuministros.Rows.Add(new object[] { s.IdSuministro, s.Nombre, s.TipoSuministro.IdTipoSuministro, s.TipoSuministro.NombreTipoSuministro, s.Descripcion, s.VentaLibre, s.Precio });
            }
        }
        private void dgvSuministros_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSuministros.CurrentCell.ColumnIndex == 8)
            {
                BorrarFila();
            }
            if (dgvSuministros.CurrentCell.ColumnIndex == 7)
            {
                EditarFila();
            }
        }
        private void EditarFila()
        {
            txtCodigo.Text = Convert.ToInt32(dgvSuministros.CurrentRow.Cells[0].Value).ToString();
            txtCodigo.Enabled = false;
            dgvSuministros.Enabled = false;
            btnGuardarCambios.Enabled = true;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void BorrarFila()
        {
            serviceSuministro.Delete(Convert.ToInt32(dgvSuministros.CurrentRow.Cells[0].Value));
            dgvSuministros.Rows.Clear();
            CargarlistaDB();
            CargarGrilla();
        }
        private Suministro ConstruirObjeto()
        {
            Suministro suministro = new Suministro();
            suministro.IdSuministro = Convert.ToInt32(txtCodigo.Text);
            suministro.Nombre = txtSuministro.Text;
            suministro.Descripcion = txtDescripcion.Text;
            suministro.Precio = Convert.ToDouble(txtPrecio.Text);
            //{
            //    IdSuministro = Convert.ToInt32(txtCodigo.Text),
            //    Nombre = txtSuministro.Text,
            //    Descripcion = txtDescripcion.Text,
            //    Precio = Convert.ToDouble(txtPrecio)
            //};
            if (rbtYes.Checked)
            {
                suministro.VentaLibre = "S";
            }
            else
            {
                suministro.VentaLibre = "N";
            }
            TipoSuministro tipo_suministro = (TipoSuministro)cboTipo.SelectedItem;
            suministro.TipoSuministro = tipo_suministro;

            return suministro;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            dgvSuministros.Enabled = true;
            serviceSuministro.Update(ConstruirObjeto());
            dgvSuministros.Rows.Clear();
            CargarlistaDB();
            CargarGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
