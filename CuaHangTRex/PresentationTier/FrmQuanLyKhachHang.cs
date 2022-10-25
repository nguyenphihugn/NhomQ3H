using System.Collections.Generic;
using System.ComponentModel;
using CuaHangTRex.DataTier.Models;
using CuaHangTRex.LogicTier;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangTRex.ViewModel;

namespace CuaHangTRex.PresentationTier
{
    public partial class FrmQuanLyKhachHang : Form
    {
        private readonly KhachHangBUS khachHangBUS;
        private IEnumerable<KhachHangViewModel> danhSachKhachHang;

        public FrmQuanLyKhachHang()
        {
            InitializeComponent();
            khachHangBUS = new KhachHangBUS();
            this.Load += FrmKhachHang_Load;
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            danhSachKhachHang = khachHangBUS.GetKhachHangs();
            dgvKhachHang.DataSource = danhSachKhachHang;
        }


        private void CaiDatChucNang(bool status)
        {
            txtTenKH.Text = txtMaKH.Text = txtDiaChi.Text = txtSDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // kiem tra thong tin
            string thongBao = "";
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                thongBao += "Vui lòng nhập mã khách hàng\n";
                MessageBox.Show(thongBao, "Thông Báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                thongBao += "Vui lòng nhập Họ tên\n";
                MessageBox.Show(thongBao, "Thông Báo");
                return;
            }
            Khach_Hang kh = new Khach_Hang();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.SDT = txtSDT.Text;
            kh.DiaChi = txtDiaChi.Text;

            try
            {
                khachHangBUS.ThemKhachHang(kh);
                LoadKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")

            {
                MessageBox.Show("Vui lòng chọn nhân viên!!");
                return;
            }
            try
            {
                khachHangBUS.XoaKhachHang(txtMaKH.Text);
                CaiDatChucNang(false);
                LoadKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Nhập mã khách hàng cần sửa!");
                return;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Nhập tên khách hàng !");
                return;
            }

            Khach_Hang kh = new Khach_Hang();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.SDT = txtSDT.Text;
            kh.DiaChi = txtDiaChi.Text;
            try
            {
                khachHangBUS.CapNhatKhachHang(kh);
                LoadKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            CaiDatChucNang(false);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongChon = e.RowIndex;
            if (dongChon < 0)
                return;
            txtMaKH.Text = dgvKhachHang.Rows[dongChon].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[dongChon].Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[dongChon].Cells[2].Value.ToString().Trim();
            txtDiaChi.Text = dgvKhachHang.Rows[dongChon].Cells[3].Value.ToString();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.ToLower();
            List<KhachHangViewModel> ds = new List<KhachHangViewModel>(danhSachKhachHang.Where(x => x.TenKH.ToLower().Contains(timKiem)));
            dgvKhachHang.DataSource = ds;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try 
            {
                Clipboard.SetText(txtMaKH.Text.Trim());
                MessageBox.Show("Copy thành công!");
                txtMaKH.Text = string.Empty;
            }
            catch(Exception ex)
            {
                
            }

        }
    }
}
