namespace CuaHangTRex.PresentationTier
{
    partial class FrmXuatCT_PhieuNhapHang
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
            this.txtMaPN_XUAT = new System.Windows.Forms.TextBox();
            this.dgvCT_XuatPBC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_XuatPBC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPN_XUAT
            // 
            this.txtMaPN_XUAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPN_XUAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN_XUAT.Location = new System.Drawing.Point(242, 82);
            this.txtMaPN_XUAT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPN_XUAT.Name = "txtMaPN_XUAT";
            this.txtMaPN_XUAT.Size = new System.Drawing.Size(98, 22);
            this.txtMaPN_XUAT.TabIndex = 8;
            // 
            // dgvCT_XuatPBC
            // 
            this.dgvCT_XuatPBC.AllowUserToAddRows = false;
            this.dgvCT_XuatPBC.AllowUserToDeleteRows = false;
            this.dgvCT_XuatPBC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_XuatPBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_XuatPBC.Location = new System.Drawing.Point(136, 108);
            this.dgvCT_XuatPBC.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCT_XuatPBC.Name = "dgvCT_XuatPBC";
            this.dgvCT_XuatPBC.ReadOnly = true;
            this.dgvCT_XuatPBC.RowHeadersWidth = 51;
            this.dgvCT_XuatPBC.RowTemplate.Height = 24;
            this.dgvCT_XuatPBC.Size = new System.Drawing.Size(529, 254);
            this.dgvCT_XuatPBC.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Phiếu";
            // 
            // FrmXuatCT_PhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuaHangTRex.Properties.Resources.Citrus_Peel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMaPN_XUAT);
            this.Controls.Add(this.dgvCT_XuatPBC);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FrmXuatCT_PhieuNhapHang";
            this.Text = "FrmXuatCT_PhieuNhapHang";
            this.Load += new System.EventHandler(this.FrmXuatCT_PhieuNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_XuatPBC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPN_XUAT;
        private System.Windows.Forms.DataGridView dgvCT_XuatPBC;
        private System.Windows.Forms.Label label1;
    }
}