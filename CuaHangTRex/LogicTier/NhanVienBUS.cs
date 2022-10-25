using CuaHangTRex.DataTier;
using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRex.LogicTier
{
    internal class NhanVienBUS
    {
        private NhanVienDAL nhanVienDAL;

        public NhanVienBUS()
        {
            nhanVienDAL = new NhanVienDAL();
        }

        public IEnumerable<NhanVienViewModel> GetNhanViens()
        {
            return nhanVienDAL.GetNhanVien();
        }

        public IEnumerable<NhanVienViewModel> Get1NhanViens(string maNV)
        {
            return nhanVienDAL.Get1NhanVien(maNV);
        }
        public bool KiemTraDangNhap(string ten, string matKhau, out NhanVienViewModel nv)
        {
            try
            {
                return nhanVienDAL.KiemTraDangNhap(ten, matKhau, out nv);
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
                return nhanVienDAL.ThemNhanVien(nv);
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
                return nhanVienDAL.CapNhatNhanVien(nv);
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
                return nhanVienDAL.CapNhatMatKhau(nv);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
