using CuaHangTRex.DataTier.Models;
using CuaHangTRex.LogicTier;
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
    public partial class FrmQuanLiHoaDon : Form
    {
        private HoaDonBUS hoaDonBUS;
        private string maHoaDon;
        public FrmQuanLiHoaDon()
        {
            InitializeComponent();
            hoaDonBUS = new HoaDonBUS();
            loadFrom();
            txtTienGiam.Enabled = false;
            txtNgayLapHoaDon.Enabled = false;
        }
        public void loadFrom()
        {
            dgvBangHoaDon.DataSource = hoaDonBUS.GetQuanLyHoaDon();
        }

        private void dgvBangHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chon = e.RowIndex;
            if (chon < 0)
                return;
            maHoaDon = Convert.ToString(dgvBangHoaDon.Rows[chon].Cells[0].Value);
            txtMaHoaDon.Text = dgvBangHoaDon.Rows[chon].Cells[0].Value.ToString();
            txtNgayLapHoaDon.Text = dgvBangHoaDon.Rows[chon].Cells[1].Value.ToString();
            txtTienGiam.Text = dgvBangHoaDon.Rows[chon].Cells[3].Value.ToString();
            txtMaKhachHang.Text = dgvBangHoaDon.Rows[chon].Cells[4].Value.ToString();
            txtMaNhanVien.Text = dgvBangHoaDon.Rows[chon].Cells[5].Value.ToString();
            txtMaHoaDon.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {


                string thongBao = ""; // hàm đưa ra thông báo cần nhập đầy đủ
                if (string.IsNullOrWhiteSpace(txtMaHoaDon.Text))
                    thongBao += "Vui lòng chọn mã hóa hơn!\n";
                if (string.IsNullOrWhiteSpace(txtNgayLapHoaDon.Text))
                    thongBao += "Vui lòng chọn ngày lập\n";
                if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
                    thongBao += "Vui chọn mã nhân viên!\n";

                if (thongBao != "")
                {
                    MessageBox.Show(thongBao, "Thông Báo");
                    return;
                }

                Hoa_Don hd = new Hoa_Don();
                hd.MaHD = txtMaHoaDon.Text;
                hd.NgayLapHD = DateTime.Parse(txtNgayLapHoaDon.Text);
                hd.MaKH = txtMaKhachHang.Text;
                hd.MaNVLap = txtMaNhanVien.Text;
                hd.GiamGia = long.Parse(txtTienGiam.Text);

                hoaDonBUS.suaHoaDon(hd);
                loadFrom();
                MessageBox.Show("Sửa thành công!", "Thông Báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {


                string thongBao = ""; // hàm đưa ra thông báo cần nhập đầy đủ
                if (string.IsNullOrWhiteSpace(txtMaHoaDon.Text))
                    thongBao += "Vui lòng chọn mã hóa hơn!\n";
                if (string.IsNullOrWhiteSpace(txtNgayLapHoaDon.Text))
                    thongBao += "Vui lòng chọn ngày lập\n";
                if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
                    thongBao += "Vui chọn mã nhân viên!\n";

                if (thongBao != "")
                {
                    MessageBox.Show(thongBao, "Thông Báo");
                    return;
                }

                hoaDonBUS.xoaHoaDon(maHoaDon);
                loadFrom();
                MessageBox.Show("Xóa thành công!", "Thông Báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmChiTietHoaDon fr = new FrmChiTietHoaDon(txtMaHoaDon.Text);
                fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiemMahd_Click(object sender, EventArgs e)
        {
            dgvBangHoaDon.DataSource = hoaDonBUS.GetTimKiemMahd(txtMaHoaDon.Text);
        }

        private void btnTimKiemMaKH_Click(object sender, EventArgs e)
        {
            dgvBangHoaDon.DataSource = hoaDonBUS.GetTimKiemMaMaKH(txtMaKhachHang.Text);
        }
    }
    
}
