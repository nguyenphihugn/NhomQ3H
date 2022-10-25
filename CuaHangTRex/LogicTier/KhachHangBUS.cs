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
    internal class KhachHangBUS
    {
        private KhachHangDAL khachHangDAL;

        public KhachHangBUS()
        {
            khachHangDAL = new KhachHangDAL();
        }

        public IEnumerable<KhachHangViewModel> GetKhachHangs()
        {
            return khachHangDAL.GetKhachHang();
        }

        public string LayKhachHangs(string kh)
        {
            return khachHangDAL.LayKhachHangs(kh);
        }
        public bool ThemKhachHang(Khach_Hang kh)
        {
            try
            {
                return khachHangDAL.ThemKhachHang(kh);
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
                return khachHangDAL.CapNhatKhachHang(kh);
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
                return khachHangDAL.XoaKhachHang(kh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
