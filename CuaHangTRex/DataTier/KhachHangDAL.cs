using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRex.DataTier
{
    internal class KhachHangDAL
    {
        private QuanLyShopGiayModels quanLyShopGiayModels;

        public KhachHangDAL()
        {
            quanLyShopGiayModels = new QuanLyShopGiayModels();
        }

        public IEnumerable<KhachHangViewModel> GetKhachHang()
        {
            var danhSach = quanLyShopGiayModels.Khach_Hang.Select(x => new KhachHangViewModel()
            {
                MaKH = x.MaKH.ToString(),
                TenKH = x.TenKH,
                SDT = x.SDT,
                DiaChi = x.DiaChi
            }).ToList();
            return danhSach;
        }

        public string LayKhachHangs(string kh)
        {
            string MaKH = quanLyShopGiayModels.Khach_Hang.Where(x => x.MaKH == kh).Select(x => x.MaKH).FirstOrDefault();
            return MaKH;
        }
        public bool ThemKhachHang(Khach_Hang kh)
        {
            try
            {
                Khach_Hang khachHang = quanLyShopGiayModels.Khach_Hang.Where(x => x.MaKH == kh.MaKH).FirstOrDefault();
                if (khachHang != null)
                    throw new Exception("Khách hàng này đã tồn tại!!!");
                else if (kh.MaKH.Length > 11)
                    throw new Exception("Mã khách hàng không được quá 10 kí tự!!!");
                else if (kh.TenKH.Length > 30)
                    throw new Exception("Tên nhân viên không được quá 30 kí tự!!!");
                else if (kh.SDT.Length > 11)
                    throw new Exception("Số điện thoại không được quá 11 kí tự!!!!");
                else if (kh.DiaChi.Length > 60)
                    throw new Exception("Địa chỉ nhập không được quá 60 kí tự!!!!");
                quanLyShopGiayModels.Khach_Hang.Add(kh);
                quanLyShopGiayModels.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CapNhatKhachHang(Khach_Hang kh)
        {
            try
            {
                Khach_Hang khachHang = quanLyShopGiayModels.Khach_Hang.Where(x => x.MaKH == kh.MaKH).FirstOrDefault();
                if (khachHang == null)
                    throw new Exception("Khách hàng không tồn tại!!!");
                else if (kh.MaKH.Length > 11)
                    throw new Exception("Mã khách hàng không được quá 10 kí tự!!!");
                else if (kh.TenKH.Length > 30)
                    throw new Exception("Tên nhân viên không được quá 30 kí tự!!!");
                else if (kh.SDT.Length > 11)
                    throw new Exception("Số điện thoại không được quá 11 kí tự!!!!");
                else if (kh.DiaChi.Length > 60)
                    throw new Exception("Địa chỉ nhập không được quá 60 kí tự!!!!");
                else
                {
                    khachHang.TenKH = kh.TenKH;
                    khachHang.SDT = kh.SDT;
                    khachHang.DiaChi = kh.DiaChi;
                    quanLyShopGiayModels.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaKhachHang(string kh)
        {
            try
            {
                Khach_Hang khachHang = quanLyShopGiayModels.Khach_Hang.Where(x => x.MaKH == kh).FirstOrDefault();
                if (khachHang == null)
                    throw new Exception("Khách hàng không tồn tại");
                quanLyShopGiayModels.Khach_Hang.Remove(khachHang);
                quanLyShopGiayModels.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
