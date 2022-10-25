using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CuaHangTRex.DataTier
{
    internal class NhanVienDAL
    {
        private QuanLyShopGiayModels quanLyShopGiayModels;
        public NhanVienDAL()
        {
            quanLyShopGiayModels = new QuanLyShopGiayModels();
        }

        public IEnumerable<NhanVienViewModel> GetNhanVien()
        {
            var danhSach = quanLyShopGiayModels.Nhan_Vien.Select(x => new NhanVienViewModel()
            {
                MaNV = x.MaNV,
                TenNV = x.TenNV,
                Gioi_Tinh = x.Gioi_Tinh,
                SDT = x.SDT,
                Ngay_Sinh = x.Ngay_Sinh,
                Ngay_Vao_Lam = x.Ngay_Vao_Lam,
                TenTK = x.TenTK,
                ChucVu = x.ChucVu,
                MK = x.MK,
                TinhTrangHoatDong = x.TinhTrangHoatDong,
            }).ToList();
            return danhSach;
        }

        public IEnumerable<NhanVienViewModel> Get1NhanVien(string maNV)
        {
            var danhSach = quanLyShopGiayModels.Nhan_Vien.Where(x => x.MaNV == maNV).Select(x => new NhanVienViewModel()
            {
                MaNV = x.MaNV,
                TenNV = x.TenNV,
                Gioi_Tinh = x.Gioi_Tinh,
                SDT = x.SDT,
                Ngay_Sinh = x.Ngay_Sinh,
                Ngay_Vao_Lam = x.Ngay_Vao_Lam,
                TenTK = x.TenTK,
                ChucVu = x.ChucVu,
                MK = x.MK,
                TinhTrangHoatDong = x.TinhTrangHoatDong,
            }).ToList();
            return danhSach;
        }

        public bool KiemTraDangNhap(string ten, string matKhau, out NhanVienViewModel nv)
        {
            try
            {
                Nhan_Vien nhanVien = quanLyShopGiayModels.Nhan_Vien.Where(x => x.TenTK == ten && x.MK == matKhau && x.TinhTrangHoatDong == "Còn Làm").FirstOrDefault();
                nv = new NhanVienViewModel();
                if (nhanVien != null)
                {
                    nv.MaNV = nhanVien.MaNV;
                    nv.TenNV = nhanVien.TenNV;
                    nv.Gioi_Tinh = nhanVien.Gioi_Tinh;
                    nv.SDT = nhanVien.SDT;
                    nv.Ngay_Sinh = nhanVien.Ngay_Sinh;
                    nv.Ngay_Vao_Lam = nhanVien.Ngay_Vao_Lam;
                    nv.TenTK = nhanVien.TenTK;
                    nv.ChucVu = nhanVien.ChucVu;
                    nv.MK = nhanVien.MK;
                    nv.TinhTrangHoatDong = nhanVien.TinhTrangHoatDong;                 
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemNhanVien(Nhan_Vien nv)
        {
            try
            {
                DateTime dt = DateTime.Now;
                Nhan_Vien nhanVien = quanLyShopGiayModels.Nhan_Vien.Where(x => x.MaNV == nv.MaNV || x.TenTK == nv.TenTK).FirstOrDefault();
                if (nhanVien != null)
                    throw new Exception("Tên đăng nhập hoặc mã nhân viên đã tồn tại!!!");
                if (nv.TenNV.Length > 29)
                {
                    throw new Exception("Tên nhân viên không được quá 30 kí tự!");
                }
                if (nv.SDT.Length > 10) 
                {
                    throw new Exception("Số điện thoại không được quá 10 kí tự!");
                }
                if (nv.TenTK.Length > 20)
                {
                    throw new Exception("Tên tài khoản không được quá 20 kí tự!");
                }
                if (nv.MK.Length > 20)
                {
                    throw new Exception("Mật khẩu không được quá 20 kí tự!");
                }
                if (nv.Ngay_Vao_Lam > dt || nv.Ngay_Sinh > dt)
                {
                    throw new Exception("Ngày nhập vào không hợp lệ!");
                }
                else if(nv.MaNV.Length > 10)
                {
                    throw new Exception("Mã nhân viên không được quá 10 kí tự !!!");
                }
                else
                {                 
                    quanLyShopGiayModels.Nhan_Vien.Add(nv);
                    quanLyShopGiayModels.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CapNhatNhanVien(Nhan_Vien nv)
        {
            try
            {
                DateTime dt = DateTime.Now;
                Nhan_Vien nhanVien = quanLyShopGiayModels.Nhan_Vien.Where(x => x.MaNV == nv.MaNV).FirstOrDefault();
                if (nv.TenNV.Length > 29)
                {
                    throw new Exception("Tên nhân viên không được quá 30 kí tự!");
                }
                if (nv.SDT.Length > 10)
                {
                    throw new Exception("Số điện thoại không được quá 10 kí tự!");
                }
                if (nv.MK.Length > 20)
                {
                    throw new Exception("Mật khẩu không được quá 20 kí tự!");
                }
                if (nv.Ngay_Vao_Lam > dt || nv.Ngay_Sinh > dt)
                {
                    throw new Exception("Ngày nhập vào không hợp lệ!");
                }
                if (nhanVien == null)
                    throw new Exception("Nhân viên không tồn tại!!!");
                else
                {
                    nhanVien.TenNV = nv.TenNV;
                    nhanVien.MK = nv.MK;
                    nhanVien.ChucVu = nv.ChucVu;
                    nhanVien.SDT = nv.SDT;
                    nhanVien.TinhTrangHoatDong = nv.TinhTrangHoatDong;
                    nhanVien.Gioi_Tinh = nv.Gioi_Tinh;
                    nhanVien.Ngay_Vao_Lam = nv.Ngay_Vao_Lam;
                    nhanVien.Ngay_Sinh = nv.Ngay_Sinh;
                    quanLyShopGiayModels.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CapNhatMatKhau(Nhan_Vien nv)
        {
            try
            {
                Nhan_Vien nhanVien = quanLyShopGiayModels.Nhan_Vien.Where(x => x.MaNV == nv.MaNV).FirstOrDefault();
                if (nv.MK.Length > 20)
                {
                    throw new Exception("Mật khẩu không được quá 20 kí tự!");
                }
                if (nhanVien == null)
                    throw new Exception("Nhân viên không tồn tại!!!");
                else
                {
                    nhanVien.MaNV = nv.MaNV;
                    nhanVien.MK = nv.MK;
                    quanLyShopGiayModels.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
