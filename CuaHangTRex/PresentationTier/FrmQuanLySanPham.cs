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
    public partial class FrmQuanLySanPham : Form
    {
        private NoiCungCapBUS noiCungCapBUS;
        private HangBUS hangBUS;
        private SanPhamBUS sanPhamBUS;
        public static FrmQuanLySanPham instance;
        private string MaSPs;
        public FrmQuanLySanPham()
        {
            InitializeComponent();
            instance = this;
            rdoConBan.Checked = true;
            noiCungCapBUS = new NoiCungCapBUS();
            hangBUS = new HangBUS();
            sanPhamBUS = new SanPhamBUS();
        }
        private void CaiDatDieuKhien()
        {
            this.cmbNCC.DisplayMember = "TenNCC";
            this.cmbNCC.ValueMember = "MaNCC";
            this.cmbTiemKiemHang.DisplayMember = "TenLoaiSP";
            this.cmbTiemKiemHang.ValueMember = "MaLoai";
            this.cmbHangSP.DisplayMember = "TenLoaiSP";
            this.cmbHangSP.ValueMember = "MaLoai";
        }
        private void loadSP()
        {
            dgvDanhSachSanPham.DataSource = sanPhamBUS.GetSan_PhamViews();
        }
        public void FillHangSPCombobox()
        {

            this.cmbHangSP.DataSource = hangBUS.GetChung_Loais();

        }
        private void FillTimKiemHangSPCombobox()
        {
            this.cmbTiemKiemHang.DataSource = hangBUS.GetChung_Loais();

        }
        private void FillNoiCungCapCombobox()
        {
            this.cmbNCC.DataSource = noiCungCapBUS.GetNoi_Cung_Caps();

        }

        private void FrmQuanLySanPham_Load(object sender, EventArgs e)
        {
            try
            {

                FillHangSPCombobox();
                FillTimKiemHangSPCombobox();
                FillNoiCungCapCombobox();
                CaiDatDieuKhien();
                loadSP();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text == "" || txtTenSP.Text == "" || cmbHangSP.Text == "" || txtMauSacSP.Text == "" || txtSizeSP.Text == "" || txtGiaBanSP.Text == "" || txtSoLuongSP.Text == "" || cmbNCC.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sản phẩm");
                }
                DialogResult dlr = MessageBox.Show("Bạn Có chắc chắn muốn thêm 1 sản phẩm mới không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    //San_Pham sd = sanPhamBUS.GetSan_Phams().FirstOrDefault(z=> z.MaSP == txtMaSP.Text).ToString();
                    San_Pham s = new San_Pham()
                    {
                        MaSP = txtMaSP.Text,
                        TenSP = txtTenSP.Text.ToString(),
                        MauSac = txtMauSacSP.Text,
                        Size = float.Parse(txtSizeSP.Text),
                        Don_Gia_Ban = long.Parse(txtGiaBanSP.Text),
                        SL_TonKho = int.Parse(txtSoLuongSP.Text),
                        Tinh_Trang_SP = rdoConBan.Checked ? "Còn Bán" : "Không Còn Bán"
                    };
                    s.MaLoai = cmbHangSP.SelectedValue.ToString();
                    s.MaNCC = cmbNCC.SelectedValue.ToString();
                    sanPhamBUS.them(s);

                    MessageBox.Show("Thêm mới dữ liệu thành công !!!", "Thông Báo", MessageBoxButtons.OK);
                    loadSP();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaThongTinSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text == "" || txtTenSP.Text == "" || cmbHangSP.Text == "" || txtMauSacSP.Text == "" || txtSizeSP.Text == "" || txtGiaBanSP.Text == "" || txtSoLuongSP.Text == "" || cmbNCC.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sản phẩm");
                }

                DialogResult dlr = MessageBox.Show("Bạn Có chắc chắn muốn thay đổi thông tin sản phẩm này sản phẩm mới không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    San_Pham dbUpdate = new San_Pham();
                    dbUpdate.MaSP = MaSPs;
                    dbUpdate.TenSP = txtTenSP.Text;
                    dbUpdate.MauSac = txtMauSacSP.Text;
                    dbUpdate.Size = float.Parse(txtSizeSP.Text);
                    dbUpdate.Don_Gia_Ban = long.Parse(txtGiaBanSP.Text);
                    dbUpdate.SL_TonKho = int.Parse(txtSoLuongSP.Text);
                    dbUpdate.Tinh_Trang_SP = rdoConBan.Checked ? "Còn Bán" : "Không Còn Bán";
                    dbUpdate.MaLoai = cmbHangSP.SelectedValue.ToString();
                    dbUpdate.MaNCC = cmbNCC.SelectedValue.ToString();
                    sanPhamBUS.Update(dbUpdate);

                    MessageBox.Show("Đã cập nhật dữ liệu thành công !!!", "Thông Báo", MessageBoxButtons.OK);
                    loadSP();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvDanhSachSanPham.Rows[e.RowIndex];
                MaSPs = row.Cells[0].Value.ToString();
                txtMaSP.Text = MaSPs;
                txtTenSP.Text = row.Cells[1].Value.ToString();
                txtMauSacSP.Text = row.Cells[3].Value.ToString();
                txtSizeSP.Text = row.Cells[2].Value.ToString();
                txtSoLuongSP.Text = row.Cells[4].Value.ToString();

                foreach (var item in sanPhamBUS.GetSan_Phams())
                {
                    if (item.MaSP == MaSPs)
                    {
                        cmbHangSP.Text = hangBUS.GetChung_Loais().Where(x => x.MaLoai == item.MaLoai).Select(x => x.TenLoaiSP).FirstOrDefault();
                        txtGiaBanSP.Text = item.Don_Gia_Ban.ToString();
                        cmbNCC.Text = noiCungCapBUS.GetNoi_Cung_Caps().Where(c => c.MaNCC == item.MaNCC).Select(x => x.TenNCC).FirstOrDefault();

                        if (item.Tinh_Trang_SP.ToString() == "Còn Bán")
                        {
                            rdoConBan.Checked = true;
                            rdoKhongConBan.Checked = false;
                        }
                        else
                        {
                            rdoKhongConBan.Checked = true;
                            rdoConBan.Checked = false;
                        }

                        return;

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadSP();
            FillHangSPCombobox();
            txtMaSP.Text = null;
            txtTenSP.Text = null;
            txtMauSacSP.Text = null;
            txtSizeSP.Text = null;
            txtSoLuongSP.Text = null;
            txtTimKiemMa.Text = null;
            txtTimKiemTen.Text = null;
            txtGiaBanSP.Text = null;
            rdoConBan.Checked = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa Sản phẩm này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    sanPhamBUS.Delete(txtMaSP.Text);
                    loadSP();
                    MessageBox.Show("Đã xóa dữ liệu thành công !!!", "Thông Báo", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiemMa_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemMa.Text.ToLower();
            dgvDanhSachSanPham.DataSource = sanPhamBUS.TimKiemTheoMaSP(timKiem);
        }

        private void txtTimKiemTen_TextChanged(object sender, EventArgs e)
        {
            string timKiem = cmbTiemKiemHang.SelectedValue.ToString();
            dgvDanhSachSanPham.DataSource = sanPhamBUS.TimKiemTheoHangSP(timKiem);
        }

        private void cmbTiemKiemHang_SelectedValueChanged(object sender, EventArgs e)
        {
            string timKiem = cmbTiemKiemHang.SelectedValue.ToString();
            dgvDanhSachSanPham.DataSource = sanPhamBUS.TimKiemTheoHangSP(timKiem);
        }

        private void btnFrmHang_Click(object sender, EventArgs e)
        {
            Form frm = new FrmQuanLyHang();
            //this.Hide();
            frm.ShowDialog();
            this.Show();
            FillHangSPCombobox();
            FillTimKiemHangSPCombobox();
        }
    }
}
