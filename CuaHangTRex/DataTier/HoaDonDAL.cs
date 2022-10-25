using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTRex.DataTier
{
    internal class HoaDonDAL
    {
        private QuanLyShopGiayModels quanLyShopGiayModels;

        public HoaDonDAL()
        {
            quanLyShopGiayModels = new QuanLyShopGiayModels();
        }
        public IEnumerable<HoaDonViewModel> GetQuanLyHoaDon()
        {
            var danhSachHD = quanLyShopGiayModels.Hoa_Don.Select(x => new HoaDonViewModel()
            {
                MaHD = x.MaHD,
                MaKH = x.MaKH,
                MaNVLap = x.MaNVLap,
                TongTien = x.TongTien,
                NgayLapHD = x.NgayLapHD,
                GiamGia = x.GiamGia,
            }).ToList();

            return danhSachHD;
        }

        public void ThemHoaDon(Hoa_Don hd)
        {
            quanLyShopGiayModels.Hoa_Don.Add(hd);
            quanLyShopGiayModels.SaveChanges();
        }
        public bool suaHoaDon(Hoa_Don hd)
        {
            try
            {
                DateTime dt = DateTime.Now;
                Nhan_Vien nv = quanLyShopGiayModels.Nhan_Vien.Where(x => x.MaNV == hd.MaNVLap).FirstOrDefault();
                Khach_Hang kh = quanLyShopGiayModels.Khach_Hang.Where(x => x.MaKH == hd.MaKH).FirstOrDefault();
                Hoa_Don hds = quanLyShopGiayModels.Hoa_Don.Where(x => x.MaHD == hd.MaHD).FirstOrDefault();
                if (hds == null)
                {
                    MessageBox.Show("Hóa đơn không tồn tại");
                }
                if (hd.MaHD.Length > 10)
                    throw new Exception("Mã hoá đơn không được quá 10 kí tự");
                if (hd.MaKH.Length > 11)
                    throw new Exception("Mã khách hàng không được quá 11 kí tự");
                if (hd.NgayLapHD > dt) 
                    throw new Exception("Ngày lập không được quá ngày hiện tại!!!");
                if(nv == null)
                {
                    throw new Exception("Mã Nhan vien khong ton tai");
                }
                if (kh == null)
                {
                    throw new Exception("Mã khach hang khong ton tai");
                }
                else
                {
                    //hds.NgayLapHD = hd.NgayLapHD;
                    hds.MaNVLap = hd.MaNVLap;
                    hds.MaKH = hd.MaKH;
                    //hds.GiamGia = hd.GiamGia;
                    quanLyShopGiayModels.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool xoaHoaDon(string maHoaDon)
        {
            try
            {
                Hoa_Don hds = quanLyShopGiayModels.Hoa_Don.Where(x => x.MaHD == maHoaDon).FirstOrDefault();
                if (hds == null)
                {
                    MessageBox.Show("Mã hóa đơn không tồn tại!");
                }
                else
                {
                    quanLyShopGiayModels.Hoa_Don.Remove(hds);
                    quanLyShopGiayModels.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal IEnumerable<HoaDonViewModel_Xuat> GetTruyXuats(int thang, int nam)
        {
            return quanLyShopGiayModels.Hoa_Don.Where(x => x.NgayLapHD.Month == thang && x.NgayLapHD.Year == nam).Select(x => new HoaDonViewModel_Xuat()
            {
                MaHD = x.MaHD,
                MaKH = x.MaKH,
                TongTien = x.TongTien,
                MaNVLap = x.MaNVLap,
                NgayLapHD = x.NgayLapHD,
                GiamGia = x.GiamGia,
            }).ToList();

        }

        internal IEnumerable<HoaDonViewModel_Xuat> GetTimKiemMahd(string maHD)
        {
            return quanLyShopGiayModels.Hoa_Don.Where(x => x.MaHD == maHD).Select(x => new HoaDonViewModel_Xuat()
            {
                MaHD = x.MaHD,
                MaKH = x.MaKH,
                TongTien = x.TongTien,
                MaNVLap = x.MaNVLap,
                NgayLapHD = x.NgayLapHD,
                GiamGia = x.GiamGia,
            }).ToList();

        }

        internal IEnumerable<HoaDonViewModel_Xuat> GetTimKiemMaMaKH(string maKH)
        {
            return quanLyShopGiayModels.Hoa_Don.Where(x => x.MaKH == maKH).Select(x => new HoaDonViewModel_Xuat()
            {
                MaHD = x.MaHD,
                MaKH = x.MaKH,
                TongTien = x.TongTien,
                MaNVLap = x.MaNVLap,
                NgayLapHD = x.NgayLapHD,
                GiamGia = x.GiamGia,
            }).ToList();

        }
    }
}
