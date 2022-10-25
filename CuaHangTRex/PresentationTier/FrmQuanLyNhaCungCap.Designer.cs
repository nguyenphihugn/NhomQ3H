namespace CuaHangTRex.PresentationTier
{
    partial class FrmQuanLyNhaCungCap
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.labelSDT = new System.Windows.Forms.Label();
            this.labelTenNCC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::CuaHangTRex.Properties.Resources.eraser2;
            this.btnXoa.Location = new System.Drawing.Point(1060, 523);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(276, 70);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(409, 559);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(521, 34);
            this.txtTimkiem.TabIndex = 23;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEmail.Location = new System.Drawing.Point(839, 329);
            this.linkLabelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(161, 36);
            this.linkLabelEmail.TabIndex = 22;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "linkLabel1";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.BackColor = System.Drawing.Color.Transparent;
            this.labelSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.Location = new System.Drawing.Point(809, 224);
            this.labelSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(145, 36);
            this.labelSDT.TabIndex = 21;
            this.labelSDT.Text = "labelSDT";
            // 
            // labelTenNCC
            // 
            this.labelTenNCC.AutoSize = true;
            this.labelTenNCC.BackColor = System.Drawing.Color.Transparent;
            this.labelTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNCC.Location = new System.Drawing.Point(941, 132);
            this.labelTenNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenNCC.Name = "labelTenNCC";
            this.labelTenNCC.Size = new System.Drawing.Size(83, 36);
            this.labelTenNCC.TabIndex = 20;
            this.labelTenNCC.Text = "label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(685, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "SĐT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(685, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nhà cung cấp: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CuaHangTRex.Properties.Resources.delivery_courier;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(16, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 463);
            this.panel1.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::CuaHangTRex.Properties.Resources.pencil2;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1395, 523);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(276, 70);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Thêm/Sửa";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowUserToAddRows = false;
            this.dgvNCC.AllowUserToDeleteRows = false;
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNCC.Location = new System.Drawing.Point(0, 659);
            this.dgvNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.ReadOnly = true;
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.Size = new System.Drawing.Size(1788, 214);
            this.dgvNCC.TabIndex = 14;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // FrmQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuaHangTRex.Properties.Resources.Citrus_Peel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1788, 873);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.linkLabelEmail);
            this.Controls.Add(this.labelSDT);
            this.Controls.Add(this.labelTenNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvNCC);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuanLyNhaCungCap";
            this.Text = "FrmQuanLyNhaCungCap";
            this.Load += new System.EventHandler(this.FrmQuanLyNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label labelTenNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvNCC;
    }
}