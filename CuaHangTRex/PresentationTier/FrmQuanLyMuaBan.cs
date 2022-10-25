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
    public partial class FrmQuanLyMuaBan : Form
    {
        private const int CDL = 5;
        private const int W = 80;
        private const int H = 80;
        private const int DISTANCE = 100;
        private Button btnDaChon = null;
        private NhanHangBUS nhanHangBUS;
        private SanPhamBUS sanPhamBUS;
        private KhachHangBUS khachHangBUS;
        private HoaDonBUS hoaDonBUS;
        private ChiTietHoaDonBUS chiTietHoaDonBUS;
        string maNVHienTai;

        private double tongThanhTien = 0;

        public FrmQuanLyMuaBan(string maNV)
        {
            InitializeComponent();
            txtTongTien.Enabled = false;
            txtGia.Enabled = false;
            nhanHangBUS = new NhanHangBUS();
            sanPhamBUS = new SanPhamBUS();
            khachHangBUS = new KhachHangBUS();
            hoaDonBUS = new HoaDonBUS();
            chiTietHoaDonBUS = new ChiTietHoaDonBUS();
            cmbSanPham.Text = null;
            maNVHienTai = maNV;
        }

        private void FrmQuanLyMuaBan_Load(object sender, EventArgs e)
        {
            CaiDatDieuKhien();
            FillComboboxSize();
            LoadSanPham();
            FillComboboxMauSac();
            KhoiTaoNhanHang();
            CapNhatGiaTien();
        }

        private void TaoNhanHang(int x, int y, Chung_Loai loai)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(W, H);
            btn.Text = loai.TenLoaiSP;
            btn.Tag = loai.TenLoaiSP;
            btn.BackColor = Color.White;
            pnlNhanHang.Controls.Add(btn);
            btn.Click += btn_Click;
        }
        private void KhoiTaoNhanHang()
        {
            int x = 20, y = 16, i = 0;
            foreach (Chung_Loai loai in nhanHangBUS.GetNhanHangs())
            {
                TaoNhanHang(x, y, loai);

                i++;
                if (i % CDL == 0)
                {
                    y += DISTANCE;
                    x = 20;
                    continue;
                }
                x += DISTANCE;
            }

        }
        private void CaiDatDieuKhien()
        {
            cmbSanPham.DisplayMember = "TenSP";
            cmbSanPham.ValueMember = "MaSp";

            //cmbMauSac.DisplayMember = "MauSac";
            //cmbMauSac.ValueMember = "MaSP";
        }
        private void LoadSanPham()
        {
            List<string> TenSP = new List<string>();
            if (btnDaChon != null)
            {
                List<San_Pham> ds = sanPhamBUS.GetSanPhams().Where(x => x.Chung_Loai.TenLoaiSP == btnDaChon.Text).ToList();
                foreach (var i in ds)
                {
                    string tam = i.TenSP;
                    int t = 0;
                    foreach (var j in TenSP)
                    {
                        if (tam == j)
                        {
                            t = -1;
                        }
                    }
                    if (t != -1)
                    {
                        TenSP.Add(tam);
                    }
                }
            }
            cmbSanPham.DataSource = TenSP;
        }

        private void FillComboboxMauSac()
        {
            //ComboBox cbx = (ComboBox)sender;
            List<string> Mau = sanPhamBUS.GetSanPhams().Select(x => x.MauSac).ToList();
            //cmbMauSac.DataSource = Mau;
            List<string> MauSP = new List<string>();
            foreach (var i in Mau)
            {
                string tam = i;
                int t = 0;
                foreach (var j in MauSP)
                {
                    if (tam == j)
                    {
                        t = -1;
                    }

                }
                if (t != -1)
                {
                    MauSP.Add(tam);
                }

            }
            cmbMauSac.DataSource = MauSP;
        }
        private void FillComboboxSize()
        {
            //ComboBox cbx = (ComboBox)sender;
            List<double> size = sanPhamBUS.GetSanPhams().Select(x => x.Size).ToList();
            //cmbSize.DataSource = size;
            List<String> SizeSP = new List<String>();
            foreach (var i in size)
            {
                string tam = i.ToString();
                int t = 0;
                foreach (var j in SizeSP)
                {
                    if (tam == j)
                    {
                        t = -1;
                    }
                }
                if (t != -1)
                {

                    SizeSP.Add(tam.ToString());

                }

            }
            SizeSP.Sort();
            cmbSize.DataSource = SizeSP;
        }

        private void btn_Click(object sender, EventArgs e)
        {

            if (btnDaChon == null)
            {
                btnDaChon = sender as Button;
                btnDaChon.BackColor = Color.DarkBlue;
                btnDaChon.ForeColor = Color.White;
                LoadSanPham();
                CapNhatGiaTien();
            }
            else if (btnDaChon != sender)
            {
                btnDaChon.ForeColor = Color.Black;
                btnDaChon.BackColor = Color.White;
                btnDaChon = sender as Button;
                btnDaChon.BackColor = Color.DarkBlue;
                btnDaChon.ForeColor = Color.White;
                LoadSanPham();
                CapNhatGiaTien();
            }
        }
        private void CapNhatGiaTien()
        {
            double size = double.Parse(cmbSize.Text);
            long Dongia = sanPhamBUS.GetSanPhams().Where(x => x.TenSP == cmbSanPham.Text && x.MauSac == cmbMauSac.Text && x.Size == size && x.Chung_Loai.TenLoaiSP == btnDaChon.Text).Select(x => x.Don_Gia_Ban).FirstOrDefault();
            Dongia = Dongia * (long)nmrSoLuong.Value;
            txtGia.Text = Dongia.ToString();
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            FrmQuanLyKhachHang frmQuanLyKhachHang = new FrmQuanLyKhachHang();
            frmQuanLyKhachHang.ShowDialog();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            int rowIndex;
            double size = double.Parse(cmbSize.Text);
            string MaSP = sanPhamBUS.GetSanPhams().Where(x => x.TenSP == cmbSanPham.Text && x.MauSac == cmbMauSac.Text && x.Size == size && x.Chung_Loai.TenLoaiSP == btnDaChon.Text && x.Tinh_Trang_SP == "Còn Bán").Select(x => x.MaSP).FirstOrDefault();
            //string MaKH = khachHangBUS.GetKhachHangs().Where(x => x.MaKH == txtMaKH.Text).Select(x => x.MaKH).FirstOrDefault();
            //Khach_Hang MaKH = khachHangBUS.GetKhachHangs().Where(x => x.MaKH == txtMaKH.Text).FirstOrDefault();
            string MaKH = khachHangBUS.LayKhachHangs(txtMaKH.Text);
            if (MaSP == null)
            {
                MessageBox.Show("Không có sản phẩm này", "Thông Báo");
            }
            else if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng !!!", "Thông báo");
            }
            else if (MaKH == null)
            {
                MessageBox.Show("Khách hàng mã: " + txtMaKH.Text + " không tồn tại !!!", "Thông báo");
            }
            else
            {
                int dong = dgvSanPham.Rows.Count;
                int dk = 0;
                for (int i = 0; i < dong; i++)
                {
                    if (MaSP == dgvSanPham.Rows[i].Cells[0].Value.ToString())
                    {
                        int SoLuongTK = Convert.ToInt32(sanPhamBUS.GetSanPhams().Where(x => x.MaSP == MaSP).Select(x => x.SL_TonKho).FirstOrDefault());
                        int soLuongConLai = SoLuongTK - (int.Parse(dgvSanPham.Rows[i].Cells[4].Value.ToString()));
                        if (int.Parse(nmrSoLuong.Value.ToString()) > soLuongConLai)
                        {
                            MessageBox.Show("Nhập quá số lượng trong kho !!!\nHiện tại trong kho còn " + soLuongConLai + " mặt hàng này", "Thông báo");
                        }
                        else
                        {
                            dgvSanPham.Rows[i].Cells[4].Value = (int.Parse(dgvSanPham.Rows[i].Cells[4].Value.ToString()) + int.Parse(nmrSoLuong.Value.ToString())).ToString();
                        }
                        dk = 1;
                    }
                }
                if (dk == 0)
                {
                    rowIndex = dgvSanPham.Rows.Add();
                    dgvSanPham.Rows[rowIndex].Cells[0].Value = MaSP;
                    dgvSanPham.Rows[rowIndex].Cells[1].Value = cmbSanPham.Text;
                    dgvSanPham.Rows[rowIndex].Cells[2].Value = cmbMauSac.Text;
                    dgvSanPham.Rows[rowIndex].Cells[3].Value = cmbSize.Text;
                    dgvSanPham.Rows[rowIndex].Cells[4].Value = nmrSoLuong.Value.ToString();
                    long Dongia = sanPhamBUS.GetSanPhams().Where(x => x.TenSP == cmbSanPham.Text && x.MauSac == cmbMauSac.Text && x.Size == size && x.Chung_Loai.TenLoaiSP == btnDaChon.Text).Select(x => x.Don_Gia_Ban).FirstOrDefault();
                    dgvSanPham.Rows[rowIndex].Cells[5].Value = Dongia.ToString();
                    dgvSanPham.Rows[rowIndex].Cells[6].Value = txtMaKH.Text;
                    txtMaKH.Enabled = false;
                }
            }
            CapNhatDGVSanPham();
            CapNhatTongTien();
        }       

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvSanPham.Rows.Clear();
            CapNhatDGVSanPham();
            txtMaKH.Enabled = true;
        }

        private void CapNhatDGVSanPham()
        {
            double tongTien = 0;
            int dong = dgvSanPham.Rows.Count;
            for (int i = 0; i < dong; i++)
            {
                tongTien = tongTien + double.Parse(dgvSanPham.Rows[i].Cells[4].Value.ToString()) * double.Parse(dgvSanPham.Rows[i].Cells[5].Value.ToString());
            }
            tongThanhTien = tongTien;
            txtTongTien.Text = tongTien.ToString();
        }

        private void nmrGiamGia_ValueChanged(object sender, EventArgs e)
        {
            double soTienGiam = tongThanhTien * (double)nmrGiamGia.Value / 100;
            double thanhTien = tongThanhTien - soTienGiam;
            txtTongTien.Text = thanhTien.ToString();
        }
        private void CapNhatTongTien()
        {
            double soTienGiam = tongThanhTien * (double)nmrGiamGia.Value / 100;
            double thanhTien = tongThanhTien - soTienGiam;
            txtTongTien.Text = thanhTien.ToString();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int dong = dgvSanPham.Rows.Count;
            if (dong == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào được thêm vào !!!", "Thông Báo");
            }
            else
            {
                Hoa_Don hd = new Hoa_Don();
                int z = hoaDonBUS.GetQuanLyHoaDon().Select(x => x.MaHD).Count() + 1;
                hd.MaHD = "HD0" + z.ToString();
                hd.MaKH = txtMaKH.Text;
                hd.MaNVLap = maNVHienTai;
                hd.NgayLapHD = DateTime.Now;
                //hd.GiamGia = (int.Parse(txtTongTien.Text) * (int)nmrGiamGia.Value / 100);
                float a= (float)nmrGiamGia.Value / 100;
                int b = int.Parse(txtTongTien.Text);
                hd.GiamGia = (int)(b / (1-a) * a);
                hd.TongTien = (long)(b / (1 - a));
                hoaDonBUS.ThemHoaDon(hd);
                txtMaKH.Enabled = true;
                int soDong = dgvSanPham.Rows.Count;
                for (int i = 0; i < soDong; i++)
                {
                    CT_HD ct = new CT_HD();
                    ct.MaHD = hd.MaHD;
                    ct.MaSP = dgvSanPham.Rows[i].Cells[0].Value.ToString();
                    ct.SL_Mua = int.Parse(dgvSanPham.Rows[i].Cells[4].Value.ToString());
                    chiTietHoaDonBUS.ThemChiTietHoaDon(ct);
                }
                MessageBox.Show("Hóa đơn được thêm thành công !!!!", "Thông báo");
                dgvSanPham.Rows.Clear();
            }
        }

        private void cmbSanPham_TextChanged(object sender, EventArgs e)
        {
            CapNhatGiaTien();
        }

        private void cmbMauSac_TextChanged(object sender, EventArgs e)
        {
            CapNhatGiaTien();
        }

        private void cmbSize_TextChanged(object sender, EventArgs e)
        {
            CapNhatGiaTien();
        }

        private void nmrSoLuong_ValueChanged(object sender, EventArgs e)
        {
            CapNhatGiaTien();
        }

    }
}
