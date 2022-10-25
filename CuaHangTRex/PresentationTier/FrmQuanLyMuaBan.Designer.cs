namespace CuaHangTRex.PresentationTier
{
    partial class FrmQuanLyMuaBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nmrGiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMauSac = new System.Windows.Forms.ComboBox();
            this.cmbSanPham = new System.Windows.Forms.ComboBox();
            this.pnlNhanHang = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.nmrSoLuong);
            this.panel1.Controls.Add(this.nmrGiamGia);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnTimKH);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnADD);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbSize);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.dgvSanPham);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbMauSac);
            this.panel1.Controls.Add(this.cmbSanPham);
            this.panel1.Location = new System.Drawing.Point(841, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 808);
            this.panel1.TabIndex = 13;
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrSoLuong.Location = new System.Drawing.Point(671, 119);
            this.nmrSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(64, 30);
            this.nmrSoLuong.TabIndex = 24;
            this.nmrSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSoLuong.ValueChanged += new System.EventHandler(this.nmrSoLuong_ValueChanged);
            // 
            // nmrGiamGia
            // 
            this.nmrGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGiamGia.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrGiamGia.Location = new System.Drawing.Point(198, 668);
            this.nmrGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrGiamGia.Name = "nmrGiamGia";
            this.nmrGiamGia.Size = new System.Drawing.Size(88, 30);
            this.nmrGiamGia.TabIndex = 23;
            this.nmrGiamGia.ValueChanged += new System.EventHandler(this.nmrGiamGia_ValueChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.BackgroundImage = global::CuaHangTRex.Properties.Resources.Citrus_Peel;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::CuaHangTRex.Properties.Resources.close1;
            this.btnHuy.Location = new System.Drawing.Point(128, 732);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(167, 55);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKH.BackgroundImage = global::CuaHangTRex.Properties.Resources.search;
            this.btnTimKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKH.Location = new System.Drawing.Point(335, 191);
            this.btnTimKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(41, 30);
            this.btnTimKH.TabIndex = 20;
            this.btnTimKH.UseVisualStyleBackColor = false;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Khách hàng (Mã)";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(228, 187);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(97, 30);
            this.txtMaKH.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Giá";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.OldLace;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Image = global::CuaHangTRex.Properties.Resources.add_2_icon2;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(655, 180);
            this.btnADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(103, 48);
            this.btnADD.TabIndex = 15;
            this.btnADD.Text = "Thêm";
            this.btnADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(488, 183);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(140, 30);
            this.txtGia.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Size";
            // 
            // cmbSize
            // 
            this.cmbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(628, 41);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(105, 33);
            this.cmbSize.TabIndex = 12;
            this.cmbSize.TextChanged += new System.EventHandler(this.cmbSize_TextChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(504, 671);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(199, 30);
            this.txtTongTien.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 675);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giảm giá";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackgroundImage = global::CuaHangTRex.Properties.Resources.Citrus_Peel;
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::CuaHangTRex.Properties.Resources.credit_card;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(504, 732);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(213, 55);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.MauSac,
            this.Size,
            this.SoLuong,
            this.DonGia,
            this.MaKH});
            this.dgvSanPham.Location = new System.Drawing.Point(24, 272);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(733, 382);
            this.dgvSanPham.TabIndex = 6;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên giày";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 125;
            // 
            // MauSac
            // 
            this.MauSac.HeaderText = "Màu";
            this.MauSac.MinimumWidth = 6;
            this.MauSac.Name = "MauSac";
            this.MauSac.ReadOnly = true;
            this.MauSac.Width = 125;
            // 
            // Size
            // 
            this.Size.HeaderText = "Kích cỡ";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Khách Hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng mua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Màu sắc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên giày";
            // 
            // cmbMauSac
            // 
            this.cmbMauSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMauSac.FormattingEnabled = true;
            this.cmbMauSac.Location = new System.Drawing.Point(164, 117);
            this.cmbMauSac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMauSac.Name = "cmbMauSac";
            this.cmbMauSac.Size = new System.Drawing.Size(180, 33);
            this.cmbMauSac.TabIndex = 2;
            this.cmbMauSac.TextChanged += new System.EventHandler(this.cmbMauSac_TextChanged);
            // 
            // cmbSanPham
            // 
            this.cmbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSanPham.FormattingEnabled = true;
            this.cmbSanPham.Location = new System.Drawing.Point(164, 41);
            this.cmbSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSanPham.Name = "cmbSanPham";
            this.cmbSanPham.Size = new System.Drawing.Size(261, 33);
            this.cmbSanPham.TabIndex = 0;
            this.cmbSanPham.TextChanged += new System.EventHandler(this.cmbSanPham_TextChanged);
            // 
            // pnlNhanHang
            // 
            this.pnlNhanHang.AutoSize = true;
            this.pnlNhanHang.BackColor = System.Drawing.Color.Wheat;
            this.pnlNhanHang.Location = new System.Drawing.Point(104, 31);
            this.pnlNhanHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNhanHang.Name = "pnlNhanHang";
            this.pnlNhanHang.Size = new System.Drawing.Size(699, 808);
            this.pnlNhanHang.TabIndex = 12;
            // 
            // FrmQuanLyMuaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuaHangTRex.Properties.Resources.Citrus_Peel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1757, 898);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNhanHang);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuanLyMuaBan";
            this.Text = "FrmQuanLyMuaBan";
            this.Load += new System.EventHandler(this.FrmQuanLyMuaBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.NumericUpDown nmrGiamGia;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMauSac;
        private System.Windows.Forms.ComboBox cmbSanPham;
        private System.Windows.Forms.Panel pnlNhanHang;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
    }
}