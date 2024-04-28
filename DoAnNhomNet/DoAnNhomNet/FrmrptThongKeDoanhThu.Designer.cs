namespace DoAnNhomNet
{
    partial class FrmrptThongKeDoanhThu
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
            this.ThongKeDoanhThuTheoCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TheGioiDiDongDataSet = new DoAnNhomNet.TheGioiDiDongDataSet();
            this.rptThongKeDoanhThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeDoanhThuTheoCHTableAdapter = new DoAnNhomNet.TheGioiDiDongDataSetTableAdapters.ThongKeDoanhThuTheoCHTableAdapter();
            this.cboMaCH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDoanhThuTheoCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheGioiDiDongDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongKeDoanhThuTheoCHBindingSource
            // 
            this.ThongKeDoanhThuTheoCHBindingSource.DataMember = "ThongKeDoanhThuTheoCH";
            this.ThongKeDoanhThuTheoCHBindingSource.DataSource = this.TheGioiDiDongDataSet;
            // 
            // TheGioiDiDongDataSet1
            // 
            this.TheGioiDiDongDataSet.DataSetName = "TheGioiDiDongDataSet1";
            this.TheGioiDiDongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptThongKeDoanhThu
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ThongKeDoanhThuTheoCHBindingSource;
            this.rptThongKeDoanhThu.LocalReport.DataSources.Add(reportDataSource1);
            this.rptThongKeDoanhThu.LocalReport.ReportEmbeddedResource = "DoAnNhomNet.RptThongKeDoanhThu.rdlc";
            this.rptThongKeDoanhThu.Location = new System.Drawing.Point(12, 61);
            this.rptThongKeDoanhThu.Name = "rptThongKeDoanhThu";
            this.rptThongKeDoanhThu.ServerReport.BearerToken = null;
            this.rptThongKeDoanhThu.Size = new System.Drawing.Size(1143, 452);
            this.rptThongKeDoanhThu.TabIndex = 0;
            // 
            // ThongKeDoanhThuTheoCHTableAdapter
            // 
            this.ThongKeDoanhThuTheoCHTableAdapter.ClearBeforeFill = true;
            // 
            // cboMaCH
            // 
            this.cboMaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaCH.FormattingEnabled = true;
            this.cboMaCH.Location = new System.Drawing.Point(97, 18);
            this.cboMaCH.Name = "cboMaCH";
            this.cboMaCH.Size = new System.Drawing.Size(130, 28);
            this.cboMaCH.TabIndex = 1;
            this.cboMaCH.SelectedIndexChanged += new System.EventHandler(this.cboMaCH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã CH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(838, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Từ Ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(446, 17);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 27);
            this.dtpTuNgay.TabIndex = 9;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(931, 19);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 27);
            this.dtpDenNgay.TabIndex = 10;
            // 
            // FrmrptThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 520);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaCH);
            this.Controls.Add(this.rptThongKeDoanhThu);
            this.Name = "FrmrptThongKeDoanhThu";
            this.Text = "FrmrptThongKeDoanhThu";
            this.Load += new System.EventHandler(this.FrmrptThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDoanhThuTheoCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheGioiDiDongDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptThongKeDoanhThu;
        private System.Windows.Forms.BindingSource ThongKeDoanhThuTheoCHBindingSource;
        private TheGioiDiDongDataSet TheGioiDiDongDataSet;
        private TheGioiDiDongDataSetTableAdapters.ThongKeDoanhThuTheoCHTableAdapter ThongKeDoanhThuTheoCHTableAdapter;
        private System.Windows.Forms.ComboBox cboMaCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
    }
}