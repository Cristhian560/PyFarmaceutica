
namespace PyFarmaceutica.Reportes.FormReportes
{
    partial class FormReporteFacturacionTotal_Mes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteFacturacionTotal_Mes));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ReporteFacturacionTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteFacturacionTotalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.reportViewer1.DocumentMapWidth = 1;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteFacturacionTotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PyFarmaceutica.Reportes.FormReportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(165, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(925, 780);
            this.reportViewer1.TabIndex = 3;
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(17, 115);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(128, 24);
            this.cboAño.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Año de facturacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.AllowAnimations = true;
            this.btnGenerarReporte.AllowMouseEffects = true;
            this.btnGenerarReporte.AllowToggling = false;
            this.btnGenerarReporte.AnimationSpeed = 200;
            this.btnGenerarReporte.AutoGenerateColors = false;
            this.btnGenerarReporte.AutoRoundBorders = false;
            this.btnGenerarReporte.AutoSizeLeftIcon = true;
            this.btnGenerarReporte.AutoSizeRightIcon = true;
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarReporte.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnGenerarReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerarReporte.BackgroundImage")));
            this.btnGenerarReporte.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerarReporte.ButtonText = "Generar Reporte";
            this.btnGenerarReporte.ButtonTextMarginLeft = 0;
            this.btnGenerarReporte.ColorContrastOnClick = 45;
            this.btnGenerarReporte.ColorContrastOnHover = 45;
            this.btnGenerarReporte.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnGenerarReporte.CustomizableEdges = borderEdges1;
            this.btnGenerarReporte.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerarReporte.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGenerarReporte.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGenerarReporte.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGenerarReporte.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarReporte.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerarReporte.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGenerarReporte.IconMarginLeft = 11;
            this.btnGenerarReporte.IconPadding = 10;
            this.btnGenerarReporte.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarReporte.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerarReporte.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGenerarReporte.IconSize = 25;
            this.btnGenerarReporte.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerarReporte.IdleBorderRadius = 1;
            this.btnGenerarReporte.IdleBorderThickness = 1;
            this.btnGenerarReporte.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerarReporte.IdleIconLeftImage = null;
            this.btnGenerarReporte.IdleIconRightImage = null;
            this.btnGenerarReporte.IndicateFocus = false;
            this.btnGenerarReporte.Location = new System.Drawing.Point(17, 156);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGenerarReporte.OnDisabledState.BorderRadius = 1;
            this.btnGenerarReporte.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerarReporte.OnDisabledState.BorderThickness = 1;
            this.btnGenerarReporte.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGenerarReporte.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGenerarReporte.OnDisabledState.IconLeftImage = null;
            this.btnGenerarReporte.OnDisabledState.IconRightImage = null;
            this.btnGenerarReporte.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGenerarReporte.onHoverState.BorderRadius = 1;
            this.btnGenerarReporte.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerarReporte.onHoverState.BorderThickness = 1;
            this.btnGenerarReporte.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGenerarReporte.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.onHoverState.IconLeftImage = null;
            this.btnGenerarReporte.onHoverState.IconRightImage = null;
            this.btnGenerarReporte.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerarReporte.OnIdleState.BorderRadius = 1;
            this.btnGenerarReporte.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerarReporte.OnIdleState.BorderThickness = 1;
            this.btnGenerarReporte.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerarReporte.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.OnIdleState.IconLeftImage = null;
            this.btnGenerarReporte.OnIdleState.IconRightImage = null;
            this.btnGenerarReporte.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGenerarReporte.OnPressedState.BorderRadius = 1;
            this.btnGenerarReporte.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerarReporte.OnPressedState.BorderThickness = 1;
            this.btnGenerarReporte.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGenerarReporte.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.OnPressedState.IconLeftImage = null;
            this.btnGenerarReporte.OnPressedState.IconRightImage = null;
            this.btnGenerarReporte.Size = new System.Drawing.Size(128, 35);
            this.btnGenerarReporte.TabIndex = 7;
            this.btnGenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerarReporte.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerarReporte.TextMarginLeft = 0;
            this.btnGenerarReporte.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGenerarReporte.UseDefaultRadiusAndThickness = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // ReporteFacturacionTotalBindingSource
            // 
            this.ReporteFacturacionTotalBindingSource.DataSource = typeof(PyFarmaceutica.Reportes.entidades.ReporteFacturacionTotal_Mes);
            // 
            // FormReporteFacturacionTotal_Mes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1090, 780);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAño);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteFacturacionTotal_Mes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteFacturacionTotalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteFacturacionTotalBindingSource;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGenerarReporte;
    }
}