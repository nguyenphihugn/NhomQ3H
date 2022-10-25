namespace CuaHangTRex.PresentationTier
{
    partial class FrmQuanLyHang
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::CuaHangTRex.Properties.Resources.import;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(543, 207);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(151, 37);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::CuaHangTRex.Properties.Resources.eraser1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(543, 138);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 37);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSua
            // 
            this.btnThemSua.BackColor = System.Drawing.Color.White;
            this.btnThemSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSua.Image = global::CuaHangTRex.Properties.Resources.refresh;
            this.btnThemSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSua.Location = new System.Drawing.Point(543, 95);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(151, 37);
            this.btnThemSua.TabIndex = 9;
            this.btnThemSua.Text = "Thêm/Sửa ";
            this.btnThemSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSua.UseVisualStyleBackColor = false;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AllowUserToDeleteRows = false;
            this.dgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHang.Location = new System.Drawing.Point(95, 273);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.ReadOnly = true;
            this.dgvHang.Size = new System.Drawing.Size(610, 136);
            this.dgvHang.TabIndex = 8;
            this.dgvHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHang_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Casper", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(266, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thông Tin Hãng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTenHang);
            this.panel1.Controls.Add(this.txtMaHang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(107, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 161);
            this.panel1.TabIndex = 6;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(166, 112);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(174, 20);
            this.txtTenHang.TabIndex = 3;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(166, 34);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(174, 20);
            this.txtMaHang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Hãng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hãng";
            // 
            // FrmQuanLyHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuaHangTRex.Properties.Resources.Citrus_Peel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQuanLyHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLyHang";
            this.Load += new System.EventHandler(this.FrmQuanLyHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}