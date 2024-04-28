namespace DoAnNhomNet
{
    partial class FrmrptHoaDon
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
            this.HienThiHoaDonTheoMaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TheGioiDiDongDataSet = new DoAnNhomNet.TheGioiDiDongDataSet();
            this.rptHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.ThongKeDoanhThuTheoCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongKeDoanhThuTheoCHTableAdapter = new DoAnNhomNet.TheGioiDiDongDataSetTableAdapters.ThongKeDoanhThuTheoCHTableAdapter();
            this.HienThiHoaDonTheoMaTableAdapter = new DoAnNhomNet.TheGioiDiDongDataSetTableAdapters.HienThiHoaDonTheoMaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HienThiHoaDonTheoMaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheGioiDiDongDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDoanhThuTheoCHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HienThiHoaDonTheoMaBindingSource
            // 
            this.HienThiHoaDonTheoMaBindingSource.DataMember = "HienThiHoaDonTheoMa";
            this.HienThiHoaDonTheoMaBindingSource.DataSource = this.TheGioiDiDongDataSet;
            // 
            // TheGioiDiDongDataSet1
            // 
            this.TheGioiDiDongDataSet.DataSetName = "TheGioiDiDongDataSet1";
            this.TheGioiDiDongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptHoaDon
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HienThiHoaDonTheoMaBindingSource;
            this.rptHoaDon.LocalReport.DataSources.Add(reportDataSource1);
            this.rptHoaDon.LocalReport.ReportEmbeddedResource = "DoAnNhomNet.RptInHoaDon.rdlc";
            this.rptHoaDon.Location = new System.Drawing.Point(12, 80);
            this.rptHoaDon.Name = "rptHoaDon";
            this.rptHoaDon.ServerReport.BearerToken = null;
            this.rptHoaDon.Size = new System.Drawing.Size(1216, 438);
            this.rptHoaDon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // cboMaHD
            // 
            this.cboMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(550, 16);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(164, 28);
            this.cboMaHD.TabIndex = 4;
            this.cboMaHD.TextChanged += new System.EventHandler(this.cboMaHD_TextChanged);
            // 
            // ThongKeDoanhThuTheoCHBindingSource
            // 
            this.ThongKeDoanhThuTheoCHBindingSource.DataMember = "ThongKeDoanhThuTheoCH";
            this.ThongKeDoanhThuTheoCHBindingSource.DataSource = this.TheGioiDiDongDataSet;
            // 
            // ThongKeDoanhThuTheoCHTableAdapter
            // 
            this.ThongKeDoanhThuTheoCHTableAdapter.ClearBeforeFill = true;
            // 
            // HienThiHoaDonTheoMaTableAdapter
            // 
            this.HienThiHoaDonTheoMaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmrptHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 530);
            this.Controls.Add(this.cboMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptHoaDon);
            this.Name = "FrmrptHoaDon";
            this.Text = "FrmrptHoaDon";
            this.Load += new System.EventHandler(this.FrmrptHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HienThiHoaDonTheoMaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheGioiDiDongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDoanhThuTheoCHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptHoaDon;
        private System.Windows.Forms.BindingSource HienThiHoaDonTheoMaBindingSource;
        private TheGioiDiDongDataSet TheGioiDiDongDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.BindingSource ThongKeDoanhThuTheoCHBindingSource;
        private TheGioiDiDongDataSetTableAdapters.ThongKeDoanhThuTheoCHTableAdapter ThongKeDoanhThuTheoCHTableAdapter;
        private TheGioiDiDongDataSetTableAdapters.HienThiHoaDonTheoMaTableAdapter HienThiHoaDonTheoMaTableAdapter;
    }
}