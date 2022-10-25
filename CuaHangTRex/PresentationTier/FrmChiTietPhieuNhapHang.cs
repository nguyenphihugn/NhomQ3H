using CuaHangTRex.DataTier.Models;
using CuaHangTRex.LogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Entity.Core;
//using System.Data.Entity.Migrations;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangTRex.ViewModel;

namespace CuaHangTRex.PresentationTier
{
    public partial class FrmChiTietPhieuNhapHang : Form
    {
        //static String connString = @"Data Source=HuyHoang\SQLEXPRESS;Initial Catalog=QLShopT_Rex;Integrated Security=True";
        //SqlConnection conn = new SqlConnection(connString);
        QuanLyShopGiayModels CTphieuNhapHang = new QuanLyShopGiayModels();
        private CT_PhieuNhapHangBUS cT_PhieuNhapHangBUS;
        private PhieuNhapHangBUS phieuNhapHangBUS;
        private string MaPN;
        private FrmChiTietPhieuNhapHang instance;
        public FrmChiTietPhieuNhapHang(string data)
        {
            InitializeComponent();
            instance = this;
            cT_PhieuNhapHangBUS = new CT_PhieuNhapHangBUS();
            phieuNhapHangBUS = new PhieuNhapHangBUS();
            MaPN = data;
            txtMaPhieu.Text = MaPN;
            try
            {


                if (phieuNhapHangBUS.GetNhapHangTimKiem(txtMaPhieu.Text))
                {
                    btnXoa.Visible = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void caiDatChucNang(bool status)
        {
            txtMaPhieu.Enabled = !status;
        }

        private void loadButton(bool status)
        {
            btnThemCT.Enabled = status;
            btnSua.Enabled = status;
            btnXoa.Enabled = status;
            txtMaSanPham.Text = null;
            txtDonGia.Text = null;
            txtSoLuongNhapHang.Text = null;
        }
        //private void taiLaiTrang()
        //{
        //    if (conn.State == ConnectionState.Closed)
        //        conn.Open();
        //    SqlCommand cmd = new SqlCommand("Select * from CT_NhapHang where MaPhieuNhapHang=@MaPhieuNhapHang", conn);
        //    cmd.Parameters.AddWithValue("@MaPhieuNhapHang", MaPN);
        //    cmd.ExecuteNonQuery();
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(reader);
        //    dgvBangPhieu.DataSource = dt;
        //    if (conn.State == ConnectionState.Open)
        //        conn.Close();
        //}
        private void loadPhieuNhapHang()
        {
            //DateTime dt = DateTime.Now;
            dgvBangPhieu.DataSource = cT_PhieuNhapHangBUS.TimKiemTheoMaP(txtMaPhieu.Text);
           // NhapHangModel pnh = (NhapHangModel)phieuNhapHangBUS.GetNhapHangTimKiem(txtMaPhieu.Text);
            //if(dt.Month != pnh.NgayLap.Month || dt.Year != pnh.NgayLap.Year)
            //{
               // btnXoa.Visible = false;
            //}
            if (dgvBangPhieu.DataSource == null)
            {
                dgvBangPhieu.Rows.Clear();
            }
            //taiLaiTrang();
        }

        
        private void FrmChiTietPhieuNhapHang_Load(object sender, EventArgs e)
        {
            loadPhieuNhapHang();
            caiDatChucNang(true);
        }

        private void dgvBangPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongChon = e.RowIndex;
            if (dongChon < 0)
                return;
            txtMaPhieu.Text = dgvBangPhieu.Rows[dongChon].Cells[0].Value.ToString();
            txtMaSanPham.Text = dgvBangPhieu.Rows[dongChon].Cells[1].Value.ToString();
            //SL = dgvBangPhieu.Rows[dongChon].Cells[2].Value.ToString();
            txtSoLuongNhapHang.Text = dgvBangPhieu.Rows[dongChon].Cells[2].Value.ToString();
            txtDonGia.Text = dgvBangPhieu.Rows[dongChon].Cells[3].Value.ToString();
            btnThemCT.Enabled = false;
        }


        private void btnThemCT_Click(object sender, EventArgs e)
        {
            try
            {


                string thongBao = ""; // hàm đưa ra thông báo cần nhập đầy đủ
                if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
                    thongBao += "Vui lòng nhập sản phẩm!\n";
                if (string.IsNullOrWhiteSpace(txtSoLuongNhapHang.Text))
                    thongBao += "Vui lòng nhập số lượng\n";
                if (string.IsNullOrWhiteSpace(txtDonGia.Text))
                    thongBao += "Vui lòng nhập giá!\n";

                if (thongBao != "")
                {
                    MessageBox.Show(thongBao, "Thông Báo");
                    return;
                }

                CT_NhapHang pnh = new CT_NhapHang();
                pnh.MaPhieuNhapHang = txtMaPhieu.Text;
                pnh.MaSP = txtMaSanPham.Text;
                pnh.SL_Nhap = int.Parse(txtSoLuongNhapHang.Text);
                pnh.DonGiaNhap = long.Parse(txtDonGia.Text);


                cT_PhieuNhapHangBUS.themChiTiet(pnh);
                loadPhieuNhapHang();
                //taiLaiTrang();
                MessageBox.Show("Thêm thành công !", "Thông báo");

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
                                      //if(string.IsNullOrWhiteSpace(txtMaSanPham.Text));
                                      //    thongBao += "Vui lòng nhập mã sản phẩm\n";
                if (string.IsNullOrWhiteSpace(txtSoLuongNhapHang.Text))
                    thongBao += "Vui lòng nhập số lượng\n";
                if (string.IsNullOrWhiteSpace(txtDonGia.Text))
                    thongBao += "Vui lòng nhập giá!\n";

                if (thongBao != "")
                {
                    MessageBox.Show(thongBao, "Thông Báo");
                    return;
                }

                CT_NhapHang pnh = new CT_NhapHang();
                pnh.MaSP = txtMaSanPham.Text;
                pnh.SL_Nhap = int.Parse(txtSoLuongNhapHang.Text);
                pnh.DonGiaNhap = long.Parse(txtDonGia.Text);
                pnh.MaPhieuNhapHang = txtMaPhieu.Text;
                btnThemCT.Enabled = false;

                cT_PhieuNhapHangBUS.catNhatChiTiet(pnh);
                loadPhieuNhapHang();
                //taiLaiTrang();
                MessageBox.Show("Sửa thành công !", "Thông báo");
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


                string thongBao = ""; // hàm đưa ra thông báo cần nhập đầy đủ
                if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
                    thongBao += "Vui chọn sản phẩm!\n";
                if (string.IsNullOrWhiteSpace(txtSoLuongNhapHang.Text))
                    thongBao += "Vui chọn số lượng\n";
                if (string.IsNullOrWhiteSpace(txtDonGia.Text))
                    thongBao += "Vui chọn giá!\n";

                if (thongBao != "")
                {
                    MessageBox.Show(thongBao, "Thông Báo");
                    return;
                }

                if (MessageBox.Show("Bạn chắc chắn muốn xóa  !", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    cT_PhieuNhapHangBUS.xoaChiTiet(txtMaSanPham.Text, txtMaPhieu.Text);
                    loadPhieuNhapHang();
                    txtDonGia.Text = null;
                    txtMaSanPham.Text = null;
                    txtSoLuongNhapHang.Text = null;
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    //taiLaiTrang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void btnTaiTrang_Click(object sender, EventArgs e)
        {



            try
            {
                loadPhieuNhapHang();
                //taiLaiTrang();
                loadButton(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
