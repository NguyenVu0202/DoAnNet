namespace DoAnNhomNet
{
    partial class frmDanhSachKho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.cboMaCH = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachKho = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboMaSP);
            this.groupBox1.Controls.Add(this.cboMaCH);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(857, 186);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Kho";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(140, 50);
            this.txtMaKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(264, 31);
            this.txtMaKho.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã Kho:";
            // 
            // cboMaSP
            // 
            this.cboMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(570, 50);
            this.cboMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(263, 33);
            this.cboMaSP.TabIndex = 11;
            // 
            // cboMaCH
            // 
            this.cboMaCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaCH.FormattingEnabled = true;
            this.cboMaCH.Location = new System.Drawing.Point(140, 112);
            this.cboMaCH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaCH.Name = "cboMaCH";
            this.cboMaCH.Size = new System.Drawing.Size(264, 33);
            this.cboMaCH.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(570, 112);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(264, 31);
            this.txtSoLuong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "So Luong:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã CH:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 50);
            this.label1.TabIndex = 25;
            this.label1.Text = "THÔNG TIN KHO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachKho);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(55, 332);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(857, 268);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Cửa Hàng";
            // 
            // dgvDanhSachKho
            // 
            this.dgvDanhSachKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKho.ColumnHeadersHeight = 34;
            this.dgvDanhSachKho.Location = new System.Drawing.Point(11, 32);
            this.dgvDanhSachKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachKho.Name = "dgvDanhSachKho";
            this.dgvDanhSachKho.ReadOnly = true;
            this.dgvDanhSachKho.RowHeadersWidth = 62;
            this.dgvDanhSachKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachKho.Size = new System.Drawing.Size(839, 228);
            this.dgvDanhSachKho.TabIndex = 0;
            this.dgvDanhSachKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachKho_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(751, 631);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 44);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(538, 631);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 44);
            this.btnShow.TabIndex = 30;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(305, 631);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 44);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(98, 631);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 44);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // frmDanhSachKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 722);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frmDanhSachKho";
            this.Text = "frmDanhSachKho";
            this.Load += new System.EventHandler(this.frmDanhSachKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.ComboBox cboMaCH;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachKho;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}