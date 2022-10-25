using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRex.LogicTier
{
    internal class ChiTietHoaDonBUS
    {
        private ChiTietHoaDonDAL chiTietHoaDonDAL;

        public ChiTietHoaDonBUS()
        {
            chiTietHoaDonDAL = new ChiTietHoaDonDAL();
        }
        public void ThemChiTietHoaDon(CT_HD cthd)
        {
            chiTietHoaDonDAL.ThemChiTietHoaDon(cthd);
        }
        public IEnumerable<ChiTietHoaDonViewModel> GetQuanLyHoaDon()
        {
            return chiTietHoaDonDAL.GetQuanLyHoaDon();
        }

        public IEnumerable<ChiTietHoaDonViewModel> Getct_HoaDon_xuatBaoCao(string MaHD)
        {
            return chiTietHoaDonDAL.Getct_HoaDon_xuatBaoCao(MaHD);
        }
    }
}
