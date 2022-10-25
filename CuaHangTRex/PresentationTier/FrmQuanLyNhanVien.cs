using CuaHangTRex.DataTier.Models;
using CuaHangTRex.LogicTier;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTRex.PresentationTier
{
    public partial class FrmQuanLyNhanVien : Form
    {
        private readonly NhanVienBUS nhanVienBUS;
        private IEnumerable<NhanVienViewModel> danhSachNhanVien;
        private string maNhanVien;

        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
            this.Load += FrmQuanLyNhanVien_Load;
            cmbCapBac.Items.Insert(0, "Nhân Viên");
            cmbCapBac.Items.Insert(1, "Quản Lý");
            cmbCapBac.SelectedIndex = 0;
            cmbTinhTrang.Items.Insert(0, "Còn Làm");
            cmbTinhTrang.Items.Insert(1, "Đã Nghỉ");
            cmbTinhTrang.SelectedIndex = 0;
            cmbGioiTinh.Items.Insert(0, "Nam");
            cmbGioiTinh.Items.Insert(1, "Nữ");
            cmbGioiTinh.SelectedIndex = 0;
        }

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            CaiDatChucNang(false);
            LoadNhanVien();
        }
        private void LoadNhanVien()
        {
            //dgvNhanSu.DataSource = nhanVienBUS.GetNhanViens();
            danhSachNhanVien = nhanVienBUS.GetNhanViens();
            dgvNhanSu.DataSource = danhSachNhanVien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string thongBao = "";
            if (string.IsNullOrWhiteSpace(txtTen.Text)) thongBao += "Vui lòng nhập họ tên\n";
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text)) thongBao += "Vui lòng nhập tên đăng nhập\n";
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text)) thongBao += "Vui lòng nhập mật khẩu\n";
            if (string.IsNullOrWhiteSpace(txtMaNV.Text)) thongBao += "Vui lòng nhập mã nhân viên\n";
            if (string.IsNullOrWhiteSpace(txtNgaySinh.Text)) thongBao += "Vui lòng nhập ngày sinh\n";
            if (string.IsNullOrWhiteSpace(txtNgayVao.Text)) thongBao += "Vui lòng nhập ngày vào làm\n";
            if (string.IsNullOrWhiteSpace(txtSDT.Text)) thongBao += "Vui lòng nhập số điện thoại\n";
            if (string.IsNullOrWhiteSpace(txtXacNhan.Text)) thongBao += "Mật khẩu xác nhận phải giống với mật khẩu\n";
            
            //string check = null;
            //DateTime ngaylam = DateTime.Parse(txtNgayVao.Text);
            //if (DateTime.TryParse(check, out ngaylam) == false)
            //{
            //    thongBao += "Vui lòng nhập đúng ngày tháng kiểu (DD/MM/YYYY)";
            //}
            if (thongBao != "")
            {
                MessageBox.Show(thongBao, "Thông Báo");
                return;
            }
            Nhan_Vien nv = new Nhan_Vien();
            try
            {
                nv.Ngay_Sinh = DateTime.Parse(txtNgaySinh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh không đúng định dạng", "Thông báo lỗi");
                return ;
            }
            try
            {
                nv.Ngay_Vao_Lam = DateTime.Parse(txtNgayVao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày vào làm không đúng định dạng", "Thông báo lỗi");
                return ;
            }
            try
            {
                nv.MaNV = txtMaNV.Text;
                nv.TenNV = txtTen.Text;
                nv.TenTK = txtTenDangNhap.Text;
                nv.MK = txtMatKhau.Text;
                nv.ChucVu = cmbCapBac.Text;
                nv.TinhTrangHoatDong = cmbTinhTrang.Text;
                nv.SDT = txtSDT.Text;
                //nv.Ngay_Sinh = DateTime.Parse(txtNgaySinh.Text);
                //nv.Ngay_Vao_Lam = DateTime.Parse(txtNgayVao.Text);
                nv.Gioi_Tinh = cmbGioiTinh.Text;
            
                DialogResult result = MessageBox.Show("Xác nhận thêm?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    nhanVienBUS.ThemNhanVien(nv);
                    MessageBox.Show("Thêm thành công", "☆*: .｡. o(≧▽≦)o .｡.:*☆");
                    CaiDatChucNang(false);
                    LoadNhanVien();
                }
            }
            //catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            //{
            //    foreach (var entityValidationErrors in ex.EntityValidationErrors)
            //    {
            //        foreach (var validationError in entityValidationErrors.ValidationErrors)
            //        {
            //            System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
            //        }
            //    }
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }

        private void dgvNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongChon = e.RowIndex;
            if (dongChon < 0)
                return;
            CaiDatChucNang(true);
            maNhanVien = dgvNhanSu.Rows[dongChon].Cells[0].Value.ToString();
            txtMaNV.Text = dgvNhanSu.Rows[dongChon].Cells[0].Value.ToString();
            txtTen.Text = dgvNhanSu.Rows[dongChon].Cells[1].Value.ToString();          
            cmbGioiTinh.SelectedIndex = dgvNhanSu.Rows[dongChon].Cells[2].Value.ToString() == "Nam" ? 0 : 1;
            txtNgaySinh.Text = DateTime.Parse(dgvNhanSu.Rows[dongChon].Cells[3].Value.ToString()).ToShortDateString();
            txtSDT.Text = dgvNhanSu.Rows[dongChon].Cells[4].Value.ToString().Trim();
            txtNgayVao.Text = DateTime.Parse(dgvNhanSu.Rows[dongChon].Cells[5].Value.ToString()).ToShortDateString();
            cmbTinhTrang.SelectedIndex = dgvNhanSu.Rows[dongChon].Cells[6].Value.ToString() == "Còn Làm" ? 0 : 1;
            cmbCapBac.SelectedIndex = dgvNhanSu.Rows[dongChon].Cells[7].Value.ToString() == "Nhân Viên" ? 0 : 1;
            txtTenDangNhap.Text = dgvNhanSu.Rows[dongChon].Cells[8].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maNhanVien == "NO")
            {
                MessageBox.Show("Nhập nhân viên cần sửa!");
                return;
            }
            string thongBao = "";
            if (string.IsNullOrWhiteSpace(txtTen.Text)) thongBao += "Vui lòng nhập họ tên\n";
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text)) thongBao += "Vui lòng nhập mật khẩu\n";
            if (string.IsNullOrWhiteSpace(txtXacNhan.Text)) thongBao += "Mật khẩu xác nhận phải giống với mật khẩu\n";
            if (string.IsNullOrWhiteSpace(txtNgaySinh.Text)) thongBao += "Vui lòng nhập ngày sinh\n";
            if (string.IsNullOrWhiteSpace(txtNgayVao.Text)) thongBao += "Vui lòng nhập ngày vào làm\n";
            if (string.IsNullOrWhiteSpace(txtSDT.Text)) thongBao += "Vui lòng nhập số điện thoại\n";
            if (thongBao != "")
            {
                MessageBox.Show(thongBao, "Thông Báo");
                return;
            }
            Nhan_Vien nv = new Nhan_Vien();
            try
            {
                nv.Ngay_Sinh = DateTime.Parse(txtNgaySinh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh không đúng định dạng", "Thông báo lỗi");
                return;
            }
            try
            {
                nv.Ngay_Vao_Lam = DateTime.Parse(txtNgayVao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày vào làm không đúng định dạng", "Thông báo lỗi");
                return;
            }
            try
            {
                nv.TenNV = txtTen.Text;
                nv.MK = txtMatKhau.Text;
                nv.MaNV = maNhanVien;
                nv.ChucVu = cmbCapBac.Text;
                nv.TinhTrangHoatDong = cmbTinhTrang.Text;
                nv.SDT = txtSDT.Text;
                //nv.Ngay_Sinh = DateTime.Parse( txtNgaySinh.Text);
                //nv.Ngay_Vao_Lam = DateTime.Parse(txtNgayVao.Text);
                nv.Gioi_Tinh = cmbGioiTinh.Text;
                nhanVienBUS.CapNhatNhanVien(nv);
                MessageBox.Show("Cập nhật thành công", "(❁´◡`❁)");
                CaiDatChucNang(false);
                LoadNhanVien();
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

        private void CaiDatChucNang(bool status)
        {
            txtTen.Text = txtSDT.Text = txtTenDangNhap.Text = txtMatKhau.Text = txtXacNhan.Text = txtNgaySinh.Text = txtNgayVao.Text = txtMaNV.Text =  "";
            cmbCapBac.SelectedIndex = 0;
            cmbGioiTinh.SelectedIndex = 0;
            cmbTinhTrang.SelectedIndex = 0;
            txtTenDangNhap.Enabled = !status;
            txtMaNV.Enabled = !status;
            btnThem.Enabled = !status;
            btnSua.Enabled = status;
            maNhanVien = "NO";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtSearch.Text.ToLower();
            List<NhanVienViewModel> ds = new List<NhanVienViewModel>(danhSachNhanVien.Where(x => x.TenNV.ToLower().Contains(timKiem)));
            dgvNhanSu.DataSource = ds;
        }
    }
}
