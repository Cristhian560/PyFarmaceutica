
namespace PyFarmaceutica.Presentacion
{
    partial class FormStocksDisponible
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIdStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdSuministro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSuministro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdStock,
            this.ColumnIdSucursal,
            this.ColumnIdSuministro,
            this.ColumnSuministro,
            this.ColumnStock,
            this.ColumnStockMinimo});
            this.dataGridView1.Location = new System.Drawing.Point(44, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnIdStock
            // 
            this.ColumnIdStock.HeaderText = "IdStock";
            this.ColumnIdStock.MinimumWidth = 6;
            this.ColumnIdStock.Name = "ColumnIdStock";
            this.ColumnIdStock.ReadOnly = true;
            this.ColumnIdStock.Visible = false;
            this.ColumnIdStock.Width = 125;
            // 
            // ColumnIdSucursal
            // 
            this.ColumnIdSucursal.HeaderText = "IdSucursal";
            this.ColumnIdSucursal.MinimumWidth = 6;
            this.ColumnIdSucursal.Name = "ColumnIdSucursal";
            this.ColumnIdSucursal.ReadOnly = true;
            this.ColumnIdSucursal.Visible = false;
            this.ColumnIdSucursal.Width = 125;
            // 
            // ColumnIdSuministro
            // 
            this.ColumnIdSuministro.HeaderText = "IdSuministro";
            this.ColumnIdSuministro.MinimumWidth = 6;
            this.ColumnIdSuministro.Name = "ColumnIdSuministro";
            this.ColumnIdSuministro.ReadOnly = true;
            this.ColumnIdSuministro.Visible = false;
            this.ColumnIdSuministro.Width = 125;
            // 
            // ColumnSuministro
            // 
            this.ColumnSuministro.HeaderText = "Suministro";
            this.ColumnSuministro.MinimumWidth = 6;
            this.ColumnSuministro.Name = "ColumnSuministro";
            this.ColumnSuministro.ReadOnly = true;
            this.ColumnSuministro.Width = 125;
            // 
            // ColumnStock
            // 
            this.ColumnStock.HeaderText = "Stock";
            this.ColumnStock.MinimumWidth = 6;
            this.ColumnStock.Name = "ColumnStock";
            this.ColumnStock.ReadOnly = true;
            this.ColumnStock.Width = 125;
            // 
            // ColumnStockMinimo
            // 
            this.ColumnStockMinimo.HeaderText = "Stock Minimo";
            this.ColumnStockMinimo.MinimumWidth = 6;
            this.ColumnStockMinimo.Name = "ColumnStockMinimo";
            this.ColumnStockMinimo.ReadOnly = true;
            this.ColumnStockMinimo.Width = 125;
            // 
            // FormStocksDisponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 780);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStocksDisponible";
            this.Text = "FormStocksDisponible";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdSuministro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSuministro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockMinimo;
    }
}