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
            rbtYes.Checked = true;
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
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos(txtPrecio.Text))
            {
                dgvSuministros.Enabled = true;
                if (serviceSuministro.Update(ConstruirObjeto()))
                {
                    MessageBox.Show("LOS CAMBIOS HAN SIDO GUARDADOS");
                }
                else
                {
                    MessageBox.Show("ERROR AL GUARDAR CAMBIOS");
                }
                dgvSuministros.Rows.Clear();
                CargarlistaDB();
                CargarGrilla();
                Habilitar(true);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("EL CAMPO PRECIO NO PUEDE ESTAR VACIO");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ComprobarCampos(txtCodigo.Text)||!ComprobarCampos(txtPrecio.Text))
            {
                MessageBox.Show("EL CAMPO CODIGO O PRECIO NO PUEDE ESTAR VACIO!!");
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
                if(serviceSuministro.Insert(ConstruirObjeto()))
                {
                    MessageBox.Show("EL SUMINISTRO SE AGREGO CORRECTAMENTE");
                }
                else
                {
                    MessageBox.Show("ERROR AL AGRAGAR SUMINISTRO");
                }
                CargarlistaDB();
                CargarGrilla();
                LimpiarCampos();
            }
        }

        private bool ComprobarCampos(string campo)
        {
            if(!(campo == ""))
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
            Habilitar(false);
        }

        private void BorrarFila()
        {
            if (MessageBox.Show("BORRAR EL SUMINISTRO : "+ dgvSuministros.CurrentRow.Cells[1].Value.ToString()+" ?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                serviceSuministro.Delete(Convert.ToInt32(dgvSuministros.CurrentRow.Cells[0].Value));
                dgvSuministros.Rows.Clear();
                CargarlistaDB();
                CargarGrilla();
            }
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
        
        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtSuministro.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
        }
        private void Habilitar(bool x)
        {
            txtCodigo.Enabled = x;
            dgvSuministros.Enabled = x;
            btnGuardarCambios.Enabled = !x;
            btnAgregar.Enabled = x;
            btnCancelar.Enabled = !x;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (X(txtCodigo.Text))
            {
                
            }
            else
            {
                MessageBox.Show("CODIGO INCORRECTO");
                txtCodigo.Text = "";
            }
        }
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (X(txtPrecio.Text))
            {

            }
            else
            {
                MessageBox.Show("PRECIO INCORRECTO");
                txtPrecio.Text = "";
            }
        }

        private bool X(string campo)
        {
            bool b = false;
            if (campo!="")
            {
                for (int i = 0; i < campo.Length; i++)
                {
                    if (Char.IsDigit(campo, i))
                    {
                        b = true;
                    }
                    else
                    {
                        b = false;
                    }
                }
            }
            else
            {
                b = true;
            }
            return b;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            LimpiarCampos();
        }
    }
}
