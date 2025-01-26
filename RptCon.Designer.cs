namespace SMDL
{
    partial class RptCon
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
            this.ConsultatonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SMDLDBDataSet = new SMDL.SMDLDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConsultatonTableAdapter = new SMDL.SMDLDBDataSetTableAdapters.ConsultatonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultatonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMDLDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultatonBindingSource
            // 
            this.ConsultatonBindingSource.DataMember = "Consultaton";
            this.ConsultatonBindingSource.DataSource = this.SMDLDBDataSet;
            // 
            // SMDLDBDataSet
            // 
            this.SMDLDBDataSet.DataSetName = "SMDLDBDataSet";
            this.SMDLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ConsultatonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SMDL.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.PromptAreaCollapsed = true;
            this.reportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportViewer1.Size = new System.Drawing.Size(890, 424);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // ConsultatonTableAdapter
            // 
            this.ConsultatonTableAdapter.ClearBeforeFill = true;
            // 
            // RptCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 424);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptCon";
            this.Text = "تقرير استشارة";
            this.Load += new System.EventHandler(this.RptCon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultatonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMDLDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.BindingSource ConsultatonBindingSource;
        public SMDLDBDataSet SMDLDBDataSet;
        public SMDLDBDataSetTableAdapters.ConsultatonTableAdapter ConsultatonTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}