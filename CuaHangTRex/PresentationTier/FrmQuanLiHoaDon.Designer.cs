namespace CuaHangTRex.PresentationTier
{
    partial class FrmQuanLiHoaDon
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
            this.dgvBangHoaDon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtNgayLapHoaDon = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTienGiam = new System.Windows.Forms.TextBox();
            this.btnTimKiemMaKH = new System.Windows.Forms.Button();
            this.btnTimKiemMahd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBangHoaDon
            // 
            this.dgvBangHoaDon.AllowUserToAddRows = false;
            this.dgvBangHoaDon.AllowUserToDeleteRows = false;
            this.dgvBangHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvBangHoaDon.Location = new System.Drawing.Point(1003, 0);
            this.dgvBangHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBangHoaDon.Name = "dgvBangHoaDon";
            this.dgvBangHoaDon.ReadOnly = true;
            this.dgvBangHoaDon.RowHeadersWidth = 51;
            this.dgvBangHoaDon.RowTemplate.Height = 24;
            this.dgvBangHoaDon.Size = new System.Drawing.Size(596, 916);
            this.dgvBangHoaDon.TabIndex = 9;
            this.dgvBangHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangHoaDon_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(636, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhân viên lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(315, 360);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(156, 41);
            this.txtMaHoaDon.TabIndex = 5;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(315, 432);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(156, 41);
            this.txtMaKhachHang.TabIndex = 7;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(315, 504);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(156, 41);
            this.txtMaNhanVien.TabIndex = 8;
            // 
            // txtNgayLapHoaDon
            // 
            this.txtNgayLapHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLapHoaDon.Location = new System.Drawing.Point(821, 434);
            this.txtNgayLapHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayLapHoaDon.Name = "txtNgayLapHoaDon";
            this.txtNgayLapHoaDon.Size = new System.Drawing.Size(186, 41);
            this.txtNgayLapHoaDon.TabIndex = 9;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(832, 648);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(165, 58);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(723, 250);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(182, 81);
            this.btnXem.TabIndex = 13;
            this.btnXem.Text = "Xem chi tiết";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CuaHangTRex.Properties.Resources.receipt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 308);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtTienGiam
            // 
            this.txtTienGiam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienGiam.Location = new System.Drawing.Point(821, 507);
            this.txtTienGiam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienGiam.Name = "txtTienGiam";
            this.txtTienGiam.Size = new System.Drawing.Size(186, 41);
            this.txtTienGiam.TabIndex = 15;
            // 
            // btnTimKiemMaKH
            // 
            this.btnTimKiemMaKH.Image = global::CuaHangTRex.Properties.Resources.loupe;
            this.btnTimKiemMaKH.Location = new System.Drawing.Point(477, 432);
            this.btnTimKiemMaKH.Name = "btnTimKiemMaKH";
            this.btnTimKiemMaKH.Size = new System.Drawing.Size(49, 41);
            this.btnTimKiemMaKH.TabIndex = 16;
            this.btnTimKiemMaKH.UseVisualStyleBackColor = true;
            this.btnTimKiemMaKH.Click += new System.EventHandler(this.btnTimKiemMaKH_Click);
            // 
            // btnTimKiemMahd
            // 
            this.btnTimKiemMahd.Image = global::CuaHangTRex.Properties.Resources.loupe;
            this.btnTimKiemMahd.Location = new System.Drawing.Point(477, 360);
            this.btnTimKiemMahd.Name = "btnTimKiemMahd";
            this.btnTimKiemMahd.Size = new System.Drawing.Size(49, 41);
            this.btnTimKiemMahd.TabIndex = 17;
            this.btnTimKiemMahd.UseVisualStyleBackColor = true;
            this.btnTimKiemMahd.Click += new System.EventHandler(this.btnTimKiemMahd_Click);
            // 
            // FrmQuanLiHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuaHangTRex.Properties.Resources.Citrus_Peel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1599, 916);
            this.Controls.Add(this.btnTimKiemMahd);
            this.Controls.Add(this.btnTimKiemMaKH);
            this.Controls.Add(this.txtTienGiam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.dgvBangHoaDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgayLapHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKhachHang);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQuanLiHoaDon";
            this.Text = "FrmQuanLiHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBangHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtNgayLapHoaDon;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTienGiam;
        private System.Windows.Forms.Button btnTimKiemMaKH;
        private System.Windows.Forms.Button btnTimKiemMahd;
    }
}