using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CuaHangTRex.LogicTier;
using CuaHangTRex.DataTier.Models;
using System;

namespace CuaHangTRex.PresentationTier
{

    public partial class FrmQuanLyPhieuNhapHang : Form
    {
        static String connString = @"Data Source=LAPTOP-PN7QTFQK\SQLEXPRESS;Initial Catalog=QLShopT_Rex;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connString);
        QuanLyShopGiayModels phieuNhapHang = new QuanLyShopGiayModels();
        private List<Phieu_Nhap_Hang> listNhapHang;
        private readonly PhieuNhapHangBUS phieuNhapHangBUS;
        private string maPhieuNhapHang;
        private static FrmQuanLyPhieuNhapHang instance;
        public FrmQuanLyPhieuNhapHang()
        {
            InitializeComponent();
            phieuNhapHangBUS = new PhieuNhapHangBUS();
            instance = this;
        }

        private void FrmQuanLyPhieuNhapHang_Load(object sender, EventArgs e)
        {
            loadPhieuNhapHang();
            caiDatChucNang2(true);
        }

        private void loadPhieuNhapHang()
        {
            dgvBangQuanLy.DataSource = phieuNhapHangBUS.GetNhapHangs();
        }
        private void caiDatChucNang(bool status)
        {
            txtMaNhanVien.Text = txtMaPhieu.Text = txtNgayLap.Text = "";
            txtMaPhieu.Enabled = !status;
            btnTimKiemMaHang.Enabled = status;
            btnTimKienNhanVien.Enabled = status;
            btnXemChiTiet.Enabled = status;
            btnThem.Enabled = !status;
            btnSua.Enabled = btnXoa.Enabled = status;

        }

        private void caiDatChucNang2(bool status)
        {
            if (txtMaPhieu.Text == "" && txtMaNhanVien.Text == "" && txtNgayLap.Text == "")
            {
                btnSua.Enabled = !status;
            }
            else
            {
                btnSua.Enabled = status;
            }

        }

        //private void caiDatChucNangAn(bool status)
        //{
        //    btnTimKiemMaHang.Enabled = !status;
        //    btnTimKienNhanVien.Enabled = !status;
        //}

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string thongBao = ""; // hàm đưa ra thông báo cần nhập đầy đủ
                if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
                    thongBao += "Vui lòng nhập thông tin nhân viên!\n";
                if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
                    thongBao += "Vui lòng nhập ma phieu!\n";
                if (string.IsNullOrWhiteSpace(txtNgayLap.Text))
                    thongBao += "Vui lòng nhập ngày tháng năm!\n";

                if (thongBao != "")
                {
                    MessageBox.Show(thongBao, "Thông Báo");
                    return;
                }

                Phieu_Nhap_Hang pnh = new Phieu_Nhap_Hang();
                try
                {
                    pnh.NgayLap = DateTime.Parse(txtNgayLap.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ngày lập không đúng định dạng", "Thông báo lỗi");
                    return;
                }
                pnh.MaPhieuNhapHang = txtMaPhieu.Text;
                pnh.MaNVLap = txtMaNhanVien.Text;
               


                phieuNhapHangBUS.ThemPhieuNhapHang(pnh);
                loadPhieuNhapHang();
                MessageBox.Show("Thêm thành công!", "Thông báo");
                MessageBox.Show("Yêu cầu thêm chi tiết!", "Thông báo");
                FrmChiTietPhieuNhapHang fr = new FrmChiTietPhieuNhapHang(txtMaPhieu.Text);
                fr.ShowDialog();
                //FrmBanHang frm = new FrmBanHang();
                //frm.openChildForm(new FrmQuanLyPhieuNhapHang());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void dgvBangQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int dongChon = e.RowIndex;
                if (dongChon < 0)
                    return;
                caiDatChucNang(true);
                maPhieuNhapHang = dgvBangQuanLy.Rows[dongChon].Cells[0].Value.ToString();
                txtMaPhieu.Text = dgvBangQuanLy.Rows[dongChon].Cells[0].Value.ToString();
                txtNgayLap.Text = dgvBangQuanLy.Rows[dongChon].Cells[1].Value.ToString();
                txtMaNhanVien.Text = dgvBangQuanLy.Rows[dongChon].Cells[2].Value.ToString();
                //caiDatChucNangAn(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string thongBao = ""; // hàm đưa ra thông báo cần nhập đầy đủ
                if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
                    thongBao += "Vui chọn sản phẩm!\n";
                if (string.IsNullOrWhiteSpace(txtNgayLap.Text))
                    thongBao += "Vui chọn số lượng\n";
                if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
                    thongBao += "Vui chọn giá!\n";

                if (thongBao != "")
                {
                    MessageBox.Show(thongBao, "Thông Báo");
                    return;
                }

                Phieu_Nhap_Hang pnh = new Phieu_Nhap_Hang();
                try
                {
                    pnh.NgayLap = DateTime.Parse(txtNgayLap.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ngày lập không đúng định dạng", "Thông báo lỗi");
                    return;
                }
                pnh.MaPhieuNhapHang = txtMaPhieu.Text;
                pnh.MaNVLap = txtMaNhanVien.Text;


                phieuNhapHangBUS.suaPhieuNhapHang(pnh);
                loadPhieuNhapHang();
                MessageBox.Show("Sửa thành công !", "Thông báo");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnTimKiemMaHang_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaPhieu.Text != null)
                {
                    FrmQuanLyPhieuNhapHang_Load(sender, e);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Phieu_Nhap_Hang where MaPhieuNhapHang=@MaPhieuNhapHang", conn);
                    cmd.Parameters.AddWithValue("@MaPhieuNhapHang", txtMaPhieu.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvBangQuanLy.DataSource = dt;
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {


                loadPhieuNhapHang();
                txtMaNhanVien.Text = null;
                txtMaPhieu.Text = null;
                txtNgayLap.Text = null;
                //caiDatChucNangAn(true);
                caiDatChucNang2(true);
                txtMaPhieu.Enabled = true;
                btnThem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKienNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNhanVien.Text != null)
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Phieu_Nhap_Hang where MaNVLap=@MaNVLap", conn);
                    cmd.Parameters.AddWithValue("@MaNVLap", txtMaNhanVien.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvBangQuanLy.DataSource = dt;
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtMaPhieu.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn mã phiếu !", "Thông báo"); ;
                }
                
                phieuNhapHangBUS.xoaPhieuNhapHang(txtMaPhieu.Text, txtMaNhanVien.Text);
                //caiDatChucNang(false);
                loadPhieuNhapHang();
                //txtMaPhieu.Text = null;
                //txtMaNhanVien.Text = null;
                //txtNgayLap.Text = null;
                MessageBox.Show("Xóa thành công !", "Thông báo");
                //this.Close();
                //FrmBanHang frm = new FrmBanHang();
                //frm.openChildForm(new FrmQuanLyPhieuNhapHang());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPhieu.Text == "")
                {
                    MessageBox.Show("Vui Lòng Chọn Mã Phiếu!!!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    FrmChiTietPhieuNhapHang fr = new FrmChiTietPhieuNhapHang(txtMaPhieu.Text);
                    this.Hide();
                    fr.Show();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
