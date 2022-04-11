namespace CAIFGUA2
{
    partial class ReporteUsuar
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cAIFGUADataSet1 = new CAIFGUA2.CAIFGUADataSet1();
            this.vusuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_usuariosTableAdapter = new CAIFGUA2.CAIFGUADataSet1TableAdapters.V_usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cAIFGUADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vusuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vusuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CAIFGUA2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1259, 841);
            this.reportViewer1.TabIndex = 0;
            // 
            // cAIFGUADataSet1
            // 
            this.cAIFGUADataSet1.DataSetName = "CAIFGUADataSet1";
            this.cAIFGUADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vusuariosBindingSource
            // 
            this.vusuariosBindingSource.DataMember = "V_usuarios";
            this.vusuariosBindingSource.DataSource = this.cAIFGUADataSet1;
            // 
            // v_usuariosTableAdapter
            // 
            this.v_usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteUsuar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 841);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteUsuar";
            this.Text = "ReporteUsuar";
            this.Load += new System.EventHandler(this.ReporteUsuar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAIFGUADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vusuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CAIFGUADataSet1 cAIFGUADataSet1;
        private System.Windows.Forms.BindingSource vusuariosBindingSource;
        private CAIFGUADataSet1TableAdapters.V_usuariosTableAdapter v_usuariosTableAdapter;
    }
}