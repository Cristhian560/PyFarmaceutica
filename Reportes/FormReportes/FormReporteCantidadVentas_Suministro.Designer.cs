
namespace PyFarmaceutica.Reportes.FormReportes
{
    partial class FormReporteCantidadVentas_Suministro
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReporteCantidadVentas_SuministroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCantidadVentas_SuministroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteCantidadVentas_SuministroBindingSource
            // 
            this.ReporteCantidadVentas_SuministroBindingSource.DataSource = typeof(PyFarmaceutica.Reportes.entidades.ReporteCantidadVentas_Suministro);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.reportViewer1.DocumentMapWidth = 1;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "DataSetCantidadVentas_Suministro";
            reportDataSource1.Value = this.ReporteCantidadVentas_SuministroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PyFarmaceutica.Reportes.FormReportes.ReporteCantidadVentas_Suministro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(165, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(925, 780);
            this.reportViewer1.TabIndex = 4;
            // 
            // FormReporteCantidadVentas_Suministro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1090, 780);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteCantidadVentas_Suministro";
            this.Text = "FormReporteCantidadVentas_Suministro";
            this.Load += new System.EventHandler(this.FormReporteCantidadVentas_Suministro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCantidadVentas_SuministroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteCantidadVentas_SuministroBindingSource;
    }
}