namespace CuaHangTRex.PresentationTier
{
    partial class FrmChiTietPhieuNhapHang
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTaiTrang = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.dgvBangPhieu = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhapHang = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Moccasin;
            this.btnSua.Location = new System.Drawing.Point(219, 358);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 49);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTaiTrang
            // 
            this.btnTaiTrang.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnTaiTrang.Location = new System.Drawing.Point(428, 138);
            this.btnTaiTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiTrang.Name = "btnTaiTrang";
            this.btnTaiTrang.Size = new System.Drawing.Size(102, 39);
            this.btnTaiTrang.TabIndex = 33;
            this.btnTaiTrang.Text = "Tải Trang";
            this.btnTaiTrang.UseVisualStyleBackColor = false;
            this.btnTaiTrang.Click += new System.EventHandler(this.btnTaiTrang_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 32;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieu.Location = new System.Drawing.Point(219, 148);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(184, 22);
            this.txtMaPhieu.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Mã phiếu nhập hàng ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 29;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Moccasin;
            this.btnXoa.Location = new System.Drawing.Point(321, 358);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 49);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.Color.Moccasin;
            this.btnThemCT.Location = new System.Drawing.Point(117, 358);
            this.btnThemCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(96, 49);
            this.btnThemCT.TabIndex = 26;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseVisualStyleBackColor = false;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // dgvBangPhieu
            // 
            this.dgvBangPhieu.AllowUserToAddRows = false;
            this.dgvBangPhieu.AllowUserToDeleteRows = false;
            this.dgvBangPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangPhieu.Location = new System.Drawing.Point(552, 138);
            this.dgvBangPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBangPhieu.Name = "dgvBangPhieu";
            this.dgvBangPhieu.ReadOnly = true;
            this.dgvBangPhieu.RowHeadersWidth = 51;
            this.dgvBangPhieu.RowTemplate.Height = 24;
            this.dgvBangPhieu.Size = new System.Drawing.Size(586, 258);
            this.dgvBangPhieu.TabIndex = 25;
            this.dgvBangPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangPhieu_CellClick);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(219, 308);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(184, 22);
            this.txtDonGia.TabIndex = 24;
            // 
            // txtSoLuongNhapHang
            // 
            this.txtSoLuongNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongNhapHang.Location = new System.Drawing.Point(219, 255);
            this.txtSoLuongNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongNhapHang.Name = "txtSoLuongNhapHang";
            this.txtSoLuongNhapHang.Size = new System.Drawing.Size(184, 22);
            this.txtSoLuongNhapHang.TabIndex = 23;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSanPham.Location = new System.Drawing.Point(219, 202);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(184, 22);
            this.txtMaSanPham.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số lượng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chi Tiết Phiếu Nhập Hàng";
            // 
            // FrmChiTietPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuaHangTRex.Properties.Resources.Citrus_Peel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTaiTrang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemCT);
            this.Controls.Add(this.dgvBangPhieu);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuongNhapHang);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChiTietPhieuNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChiTietPhieuNhapHang";
            this.Load += new System.EventHandler(this.FrmChiTietPhieuNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTaiTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.DataGridView dgvBangPhieu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuongNhapHang;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}