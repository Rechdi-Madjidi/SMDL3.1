﻿namespace SMDL
{
    partial class RptSes
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
            this.SessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SMDLDBDataSet = new SMDL.SMDLDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SessionTableAdapter = new SMDL.SMDLDBDataSetTableAdapters.SessionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMDLDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionBindingSource
            // 
            this.SessionBindingSource.DataMember = "Session";
            this.SessionBindingSource.DataSource = this.SMDLDBDataSet;
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
            reportDataSource1.Value = this.SessionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SMDL.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(938, 426);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // SessionTableAdapter
            // 
            this.SessionTableAdapter.ClearBeforeFill = true;
            // 
            // RptSes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 426);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptSes";
            this.Text = "تقارير الجلسات";
            this.Load += new System.EventHandler(this.RptSes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMDLDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource SessionBindingSource;
        public SMDLDBDataSet SMDLDBDataSet;
        public SMDLDBDataSetTableAdapters.SessionTableAdapter SessionTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}