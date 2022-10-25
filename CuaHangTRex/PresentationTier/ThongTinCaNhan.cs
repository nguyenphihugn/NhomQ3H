using CuaHangTRex.DataTier.Models;
using CuaHangTRex.LogicTier;
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

namespace CuaHangTRex.PresentationTier
{
    public partial class ThongTinCaNhan : Form
    {
        private readonly NhanVienBUS nhanVienBUS;
        private string maNV;
        public ThongTinCaNhan(string nv)
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
            maNV = nv;
            LoadThongTin(maNV);
            txtMKCu.PasswordChar = '*';
            txtMKMoi.PasswordChar = '*';
            txtXacNhan.PasswordChar = '*';        
        }

        private void LoadThongTin(string maNV)
        {
            dgvThongTin.DataSource = nhanVienBUS.Get1NhanViens(maNV);          
            dgvThongTin.Rows[0].Cells[9].Value = null;
            if (dgvThongTin.Rows[0].Cells[2].Value.ToString() == "Nam")
            {
                pictureBox1.BackgroundImage = Properties.Resources.undraw_Male_avatar_re_tqsc_removebg_preview;

            }
            else
            {
                pictureBox1.BackgroundImage = Properties.Resources.undraw_Female_avatar_re_uk8y_removebg_preview;
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (txtMKMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp", "◑﹏◐");
                return;
            }
            Nhan_Vien nv = new Nhan_Vien();
            nv.MaNV = dgvThongTin.Rows[0].Cells[0].Value.ToString();
            nv.MK = txtMKMoi.Text;
            try
            {
                nhanVienBUS.CapNhatMatKhau(nv);
                MessageBox.Show("Cập nhật thành công", "(❁´◡`❁)");
                LoadThongTin(maNV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void ckbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMKCu.PasswordChar = (ckbHienMatKhau.Checked) ? '\0' : '*';
            txtMKMoi.PasswordChar = (ckbHienMatKhau.Checked) ? '\0' : '*';
            txtXacNhan.PasswordChar = (ckbHienMatKhau.Checked) ? '\0' : '*';
        }
    }
}
