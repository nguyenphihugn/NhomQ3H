using CuaHangTRex.DataTier;
using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTRex.LogicTier
{
    internal class HoaDonBUS
    {
        private HoaDonDAL hoaDonDAL;

        public HoaDonBUS()
        {
            hoaDonDAL = new HoaDonDAL();
        }

        public IEnumerable<HoaDonViewModel> GetQuanLyHoaDon()
        {
            return hoaDonDAL.GetQuanLyHoaDon();
        }

        public void ThemHoaDon(Hoa_Don hd)
        {
            hoaDonDAL.ThemHoaDon(hd);
        }
        public bool suaHoaDon(Hoa_Don hd)
        {
            try
            {
                return hoaDonDAL.suaHoaDon(hd);
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
                return hoaDonDAL.xoaHoaDon(maHoaDon);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal IEnumerable<HoaDonViewModel_Xuat> GetTruyXuats(int thang, int nam)
        {
            return hoaDonDAL.GetTruyXuats(thang, nam);
        }
        internal IEnumerable<HoaDonViewModel_Xuat> GetTimKiemMahd(string MaHD)
        {
            return hoaDonDAL.GetTimKiemMahd(MaHD);
        }
        internal IEnumerable<HoaDonViewModel_Xuat> GetTimKiemMaMaKH(string MaKH)
        {
            return hoaDonDAL.GetTimKiemMaMaKH(MaKH);
        }
    }
}