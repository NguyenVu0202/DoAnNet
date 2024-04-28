namespace DoAnNhomNet
{
    partial class frmThongKeSanPham
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
            this.dgvBanSP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.cboMaCH = new System.Windows.Forms.ComboBox();
            this.dtpToiNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThongKeTheoSP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBanSP
            // 
            this.dgvBanSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanSP.Location = new System.Drawing.Point(7, 24);
            this.dgvBanSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBanSP.Name = "dgvBanSP";
            this.dgvBanSP.RowHeadersWidth = 62;
            this.dgvBanSP.RowTemplate.Height = 24;
            this.dgvBanSP.Size = new System.Drawing.Size(1384, 188);
            this.dgvBanSP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBanSP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(54, 546);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1397, 219);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bán Sản Phẩm";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(1056, 236);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(126, 51);
            this.btnIn.TabIndex = 40;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(577, 96);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(293, 31);
            this.txtTenSP.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tên SP:";
            // 
            // cboMaSP
            // 
            this.cboMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(112, 100);
            this.cboMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(317, 33);
            this.cboMaSP.TabIndex = 37;
            this.cboMaSP.Leave += new System.EventHandler(this.cboMaSP_Leave);
            // 
            // cboMaCH
            // 
            this.cboMaCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaCH.FormattingEnabled = true;
            this.cboMaCH.Location = new System.Drawing.Point(112, 175);
            this.cboMaCH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaCH.Name = "cboMaCH";
            this.cboMaCH.Size = new System.Drawing.Size(317, 33);
            this.cboMaCH.TabIndex = 36;
            // 
            // dtpToiNgay
            // 
            this.dtpToiNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToiNgay.Location = new System.Drawing.Point(577, 262);
            this.dtpToiNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpToiNgay.Name = "dtpToiNgay";
            this.dtpToiNgay.Size = new System.Drawing.Size(293, 31);
            this.dtpToiNgay.TabIndex = 35;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(112, 262);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(317, 31);
            this.dtpTuNgay.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Từ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mã CH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mã SP:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(1136, 88);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(126, 51);
            this.btnLamMoi.TabIndex = 24;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThongKeTheoSP
            // 
            this.btnThongKeTheoSP.Location = new System.Drawing.Point(945, 88);
            this.btnThongKeTheoSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThongKeTheoSP.Name = "btnThongKeTheoSP";
            this.btnThongKeTheoSP.Size = new System.Drawing.Size(126, 51);
            this.btnThongKeTheoSP.TabIndex = 23;
            this.btnThongKeTheoSP.Text = "Thống Kê";
            this.btnThongKeTheoSP.UseVisualStyleBackColor = true;
            this.btnThongKeTheoSP.Click += new System.EventHandler(this.btnThongKeTheoSP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboMaSP);
            this.groupBox1.Controls.Add(this.cboMaCH);
            this.groupBox1.Controls.Add(this.dtpToiNgay);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnThongKeTheoSP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(102, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1289, 350);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thống Kê";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1501, 50);
            this.label1.TabIndex = 39;
            this.label1.Text = "THỐNG KÊ SẢN PHẨM ĐÃ BÁN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 780);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmThongKeSanPham";
            this.Text = "frmThongKeSanPham";
            this.Load += new System.EventHandler(this.frmThongKeSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBanSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.ComboBox cboMaCH;
        private System.Windows.Forms.DateTimePicker dtpToiNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThongKeTheoSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}