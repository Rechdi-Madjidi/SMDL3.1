﻿namespace SMDL
{
    partial class SinglCl
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
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SMDLDBDataSet = new SMDL.SMDLDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientTableAdapter = new SMDL.SMDLDBDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMDLDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataMember = "Client";
            this.ClientBindingSource.DataSource = this.SMDLDBDataSet;
            // 
            // SMDLDBDataSet
            // 
            this.SMDLDBDataSet.DataSetName = "SMDLDBDataSet";
            this.SMDLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SMDL.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(894, 433);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // ClientTableAdapter
            // 
            this.ClientTableAdapter.ClearBeforeFill = true;
            // 
            // SinglCl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 433);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SinglCl";
            this.Text = "الطباعة";
            this.Load += new System.EventHandler(this.SinglCl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMDLDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource ClientBindingSource;
        public SMDLDBDataSetTableAdapters.ClientTableAdapter ClientTableAdapter;
        public SMDLDBDataSet SMDLDBDataSet;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}