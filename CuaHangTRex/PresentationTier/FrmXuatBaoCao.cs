using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangTRex.DataTier.Models;
using CuaHangTRex.DataTier;
using CuaHangTRex.LogicTier;


namespace CuaHangTRex.PresentationTier
{
    public partial class FrmXuatBaoCao : Form
    {
        private HoaDonBUS hoaDonBUS;
        private PhieuNhapHangBUS phieuNhapHangBUS;
        private CT_PhieuNhapHangBUS cT_PhieuNhapHangBUS;
        private ChiTietHoaDonBUS cHiTietHoaDonBUS;
        public FrmXuatBaoCao()
        {
            InitializeComponent();
            hoaDonBUS = new HoaDonBUS();
            phieuNhapHangBUS = new PhieuNhapHangBUS();
            cT_PhieuNhapHangBUS = new CT_PhieuNhapHangBUS();
            cHiTietHoaDonBUS = new ChiTietHoaDonBUS();
            labelSoHD.Visible = false;
            labelSoPNK.Visible = false;
            labelHD.Visible = false;
            labelPNK.Visible = false;
            txtChiPhi.Enabled = false;
            txtDoanhThu.Enabled = false ;
            txtLoiNhuan.Enabled = false ;
        }

        private void LoadDataGridView()
        {

        }
        private void FrmXuatBaoCao_Load(object sender, EventArgs e)
        {

        }

        private double tongChiPhi(string MaPN)
        {
            double chiphi = 0;
            foreach(var i in cT_PhieuNhapHangBUS.GetNhapHangs())
            {
                if(i.MaPhieuNhapHang == MaPN)
                {
                    double tam = i.DonGiaNhap * i.SL_Nhap;
                    chiphi = chiphi + tam;
                }
            }


            return chiphi;
        }

        //private double tongDoanhThu(string MaHD)
        //{
        //    double doanhThu = 0;
        //    foreach(var i in cHiTietHoaDonBUS.GetQuanLyHoaDon())
        //    {
        //        if(i.MaHD == MaHD)
        //        {
        //            double tam = i.tong
        //        }
        //    }
        //    return doanhThu;
        //}
        private void btnTruyXuat_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNam.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sản phẩm");
                }
                //Hoa_Don hd = new Hoa_Don();
                try
                {
                    
                    int thang = (int)numericThang.Value;   
                    int nam = int.Parse(txtNam.Text);
                    hoaDonBUS.GetTruyXuats(thang, nam);
                    phieuNhapHangBUS.GetTruyXuats(thang, nam);
                    dgvXuatHD.DataSource = hoaDonBUS.GetTruyXuats(thang, nam);
                    dgvXuatPhieuNhapHang.DataSource = phieuNhapHangBUS.GetTruyXuats(thang, nam);
                    double TongChiPhi = 0;
                    foreach( var i in phieuNhapHangBUS.GetTruyXuats(thang, nam))
                    {
                        double tam = tongChiPhi(i.MaPhieuNhapHang);
                        TongChiPhi = TongChiPhi + tam;
                    }
                    txtChiPhi.Text = TongChiPhi.ToString();

                    double tongDoanhThu = 0;
                    foreach(var i in hoaDonBUS.GetTruyXuats(thang, nam))
                    {
                        tongDoanhThu = tongDoanhThu = i.TongTien;
                    }
                    txtDoanhThu.Text = tongDoanhThu.ToString();
                    double loiNhuan = tongDoanhThu - TongChiPhi;
                    txtLoiNhuan.Text = loiNhuan.ToString();
                    int HD = 0;
                    HD = dgvXuatHD.RowCount;
                    labelSoHD.Text = HD.ToString();
                    int PNK = 0;
                    PNK = dgvXuatPhieuNhapHang.RowCount;
                    labelSoPNK.Text = PNK.ToString();
                    labelSoHD.Visible = true;
                    labelSoPNK.Visible = true;
                    labelHD.Visible = true;
                    labelPNK.Visible = true;

                }
                catch(Exception ex)
                {
                    throw new Exception("Dữ liệu không đúng định dạng");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvXuatPhieuNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvXuatPhieuNhapHang.Rows[e.RowIndex];
                string MaPN = row.Cells[0].Value.ToString();
                FrmXuatCT_PhieuNhapHang frm = new FrmXuatCT_PhieuNhapHang(MaPN);
                frm.ShowDialog();
            }
            catch(Exception ex)
            {

            }
        }

        private void dgvXuatHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvXuatHD.Rows[e.RowIndex];
                string MaHD = row.Cells[0].Value.ToString();
                
                FrmChiTietHoaDon frm = new FrmChiTietHoaDon(MaHD);
                frm.Show();
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
