using CuaHangTRex.LogicTier;
using CuaHangTRex.PresentationTier;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTRex
{
    public partial class FrmDangNhap : Form
    {
        private readonly NhanVienBUS nhanVienBUS;
        public FrmDangNhap()
        {
            InitializeComponent();
            btnDangNhap.Enabled = false;
            txtMatKhau.PasswordChar = '*';
            nhanVienBUS = new NhanVienBUS();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = !string.IsNullOrEmpty(txtMatKhau.Text) && !string.IsNullOrEmpty(txtTen.Text);
        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = (ckbHienMK.Checked) ? '\0' : '*';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                NhanVienViewModel nv = null;
                
                lblComplete.Text = "Đang kết nối " + progressBar1.Value.ToString() + "%";
                progressBar1.Increment(10);
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    timer1.Enabled = false;
                    if (nhanVienBUS.KiemTraDangNhap(txtTen.Text, txtMatKhau.Text, out nv))
                    {
                        FrmBanHang frm = new FrmBanHang(nv);
                        frm.Show();
                        frm.FormClosed += Frm_FormClosed;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng thử lại!", "Lỗi đăng nhập");
                        progressBar1.Value = 0;
                        timer1.Stop();
                        progressBar1.Enabled = true;
                        lblComplete.Visible = false;
                        progressBar1.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (progressBar1.Enabled == true)
            {
                lblComplete.Visible = true;
                progressBar1.Visible = true;
                lblDangNhap.Visible = false;
                progressBar1.Enabled = false;
                timer1.Start();
            }
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

       
    }
}
