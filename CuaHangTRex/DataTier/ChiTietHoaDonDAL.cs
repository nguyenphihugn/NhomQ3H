using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRex.DataTier.Models
{
    internal class ChiTietHoaDonDAL
    {
        private QuanLyShopGiayModels quanLyShopGiayModels;

        public ChiTietHoaDonDAL()
        {
            quanLyShopGiayModels = new QuanLyShopGiayModels();
        }

        public void ThemChiTietHoaDon(CT_HD cthd)
        {
            quanLyShopGiayModels.CT_HD.Add(cthd);
            quanLyShopGiayModels.SaveChanges();
        }
        
        public IEnumerable<ChiTietHoaDonViewModel> GetQuanLyHoaDon()
        {
            var danhSachHD = quanLyShopGiayModels.CT_HD.Select(x => new ChiTietHoaDonViewModel()
            {
                MaHD = x.MaHD,
                TenSP = x.San_Pham.TenSP,
                SL_Mua = x.SL_Mua,
            }).ToList();
            return danhSachHD;
        }


        public IEnumerable<ChiTietHoaDonViewModel> Getct_HoaDon_xuatBaoCao(string MaHD)
        {
            var danhSachHD = quanLyShopGiayModels.CT_HD.Where(x=>x.MaHD == MaHD).Select(x => new ChiTietHoaDonViewModel()
            {
                MaHD = x.MaHD,
                TenSP = x.San_Pham.TenSP,
                SL_Mua = x.SL_Mua,
            }).ToList();
            return danhSachHD;
        }
    }
}
