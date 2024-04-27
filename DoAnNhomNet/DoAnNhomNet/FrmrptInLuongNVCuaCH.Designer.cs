namespace DoAnNhomNet
{
    partial class FrmrptInLuongNVCuaCH
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaCH = new System.Windows.Forms.ComboBox();
            this.TheGioiDiDongDataSet1 = new DoAnNhomNet.TheGioiDiDongDataSet1();
            this.ThongKeLuongNVTheoMaCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongKeLuongNVTheoMaCHTableAdapter = new DoAnNhomNet.TheGioiDiDongDataSet1TableAdapters.ThongKeLuongNVTheoMaCHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TheGioiDiDongDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeLuongNVTheoMaCHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ThongKeLuongNVTheoMaCHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnNhomNet.RptInLuongNVCuaCuaHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1270, 460);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Cửa Hàng:";
            // 
            // cboMaCH
            // 
            this.cboMaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaCH.FormattingEnabled = true;
            this.cboMaCH.Location = new System.Drawing.Point(526, 16);
            this.cboMaCH.Name = "cboMaCH";
            this.cboMaCH.Size = new System.Drawing.Size(163, 28);
            this.cboMaCH.TabIndex = 2;
            this.cboMaCH.TextChanged += new System.EventHandler(this.cboMaCH_TextChanged);
            // 
            // TheGioiDiDongDataSet1
            // 
            this.TheGioiDiDongDataSet1.DataSetName = "TheGioiDiDongDataSet1";
            this.TheGioiDiDongDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThongKeLuongNVTheoMaCHBindingSource
            // 
            this.ThongKeLuongNVTheoMaCHBindingSource.DataMember = "ThongKeLuongNVTheoMaCH";
            this.ThongKeLuongNVTheoMaCHBindingSource.DataSource = this.TheGioiDiDongDataSet1;
            // 
            // ThongKeLuongNVTheoMaCHTableAdapter
            // 
            this.ThongKeLuongNVTheoMaCHTableAdapter.ClearBeforeFill = true;
            // 
            // FrmrptInLuongNVCuaCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 541);
            this.Controls.Add(this.cboMaCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmrptInLuongNVCuaCH";
            this.Text = "FrmrptInTongLuongNVCuaCH";
            this.Load += new System.EventHandler(this.FrmrptInTongLuongNVCuaCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TheGioiDiDongDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeLuongNVTheoMaCHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaCH;
        private System.Windows.Forms.BindingSource ThongKeLuongNVTheoMaCHBindingSource;
        private TheGioiDiDongDataSet1 TheGioiDiDongDataSet1;
        private TheGioiDiDongDataSet1TableAdapters.ThongKeLuongNVTheoMaCHTableAdapter ThongKeLuongNVTheoMaCHTableAdapter;
    }
}