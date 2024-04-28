namespace DoAnNhomNet
{
    partial class FrmrptThongKeSanPhamDaBanTheoMaCH
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ThongKeSanPhamDaBanCuaCuaHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TheGioiDiDongDataSet = new DoAnNhomNet.TheGioiDiDongDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaCH = new System.Windows.Forms.ComboBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.ThongKeSanPhamDaBanCuaCuaHangTableAdapter = new DoAnNhomNet.TheGioiDiDongDataSetTableAdapters.ThongKeSanPhamDaBanCuaCuaHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeSanPhamDaBanCuaCuaHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheGioiDiDongDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongKeSanPhamDaBanCuaCuaHangBindingSource
            // 
            this.ThongKeSanPhamDaBanCuaCuaHangBindingSource.DataMember = "ThongKeSanPhamDaBanCuaCuaHang";
            this.ThongKeSanPhamDaBanCuaCuaHangBindingSource.DataSource = this.TheGioiDiDongDataSet;
            // 
            // TheGioiDiDongDataSet
            // 
            this.TheGioiDiDongDataSet.DataSetName = "TheGioiDiDongDataSet";
            this.TheGioiDiDongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ThongKeSanPhamDaBanCuaCuaHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnNhomNet.RptThongKeSanPhamDaBanCuaCuaHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1054, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã CH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến Ngày:";
            // 
            // cboMaCH
            // 
            this.cboMaCH.FormattingEnabled = true;
            this.cboMaCH.Location = new System.Drawing.Point(139, 22);
            this.cboMaCH.Name = "cboMaCH";
            this.cboMaCH.Size = new System.Drawing.Size(193, 28);
            this.cboMaCH.TabIndex = 4;
            this.cboMaCH.TextChanged += new System.EventHandler(this.cboMaCH_TextChanged);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(498, 22);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 26);
            this.dtpTuNgay.TabIndex = 5;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(836, 23);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 26);
            this.dtpDenNgay.TabIndex = 6;
            // 
            // ThongKeSanPhamDaBanCuaCuaHangTableAdapter
            // 
            this.ThongKeSanPhamDaBanCuaCuaHangTableAdapter.ClearBeforeFill = true;
            // 
            // FrmrptThongKeSanPhamDaBanTheoMaCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 564);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.cboMaCH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmrptThongKeSanPhamDaBanTheoMaCH";
            this.Text = "FrmrptThongKeSanPhamDaBanTheoMaCH";
            this.Load += new System.EventHandler(this.FrmrptThongKeSanPhamDaBanTheoMaCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeSanPhamDaBanCuaCuaHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheGioiDiDongDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaCH;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.BindingSource ThongKeSanPhamDaBanCuaCuaHangBindingSource;
        private TheGioiDiDongDataSet TheGioiDiDongDataSet;
        private TheGioiDiDongDataSetTableAdapters.ThongKeSanPhamDaBanCuaCuaHangTableAdapter ThongKeSanPhamDaBanCuaCuaHangTableAdapter;
    }
}