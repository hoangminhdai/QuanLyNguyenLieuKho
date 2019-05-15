namespace N11_QLNguyenLieuNhaHang_T5.frm
{
    partial class frmTaoReport
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
            this.hoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetHoaDon = new N11_QLNguyenLieuNhaHang_T5.DataSetHoaDon();
            this.bieuMauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonNhapTableAdapter = new N11_QLNguyenLieuNhaHang_T5.DataSetHoaDonTableAdapters.HoaDonNhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bieuMauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hoaDonNhapBindingSource
            // 
            this.hoaDonNhapBindingSource.DataMember = "HoaDonNhap";
            this.hoaDonNhapBindingSource.DataSource = this.dataSetHoaDon;
            // 
            // dataSetHoaDon
            // 
            this.dataSetHoaDon.DataSetName = "DataSetHoaDon";
            this.dataSetHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bieuMauBindingSource
            // 
            this.bieuMauBindingSource.DataMember = "BieuMau";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHoaDon";
            reportDataSource1.Value = this.hoaDonNhapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "N11_QLNguyenLieuNhaHang_T5.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(732, 595);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // hoaDonNhapTableAdapter
            // 
            this.hoaDonNhapTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 595);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTaoReport";
            this.Text = "frmTaoReport";
            this.Load += new System.EventHandler(this.frmTaoReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bieuMauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        
        private System.Windows.Forms.BindingSource bieuMauBindingSource;
        
        private System.Windows.Forms.BindingSource hoaDonNhapBindingSource;
        private DataSetHoaDon dataSetHoaDon;
        private DataSetHoaDonTableAdapters.HoaDonNhapTableAdapter hoaDonNhapTableAdapter;
    }
}