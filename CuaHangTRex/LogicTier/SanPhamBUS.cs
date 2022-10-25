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
    internal class SanPhamBUS
    {
        private SanPhamDAL sanPhamDAL;
        public SanPhamBUS()
        {
            sanPhamDAL = new SanPhamDAL();
        }
        public IEnumerable<SanPhamViewModel> GetSan_Phams()
        {
            return sanPhamDAL.GetSan_Phams();
        }
        public IEnumerable<SanPhamModelView> GetSan_PhamViews()
        {
            return sanPhamDAL.GetSan_PhamViews();
        }

        public IEnumerable<San_Pham> GetSanPhams()
        {
            return sanPhamDAL.GetSanPhams();
        }
        public IEnumerable<San_Pham> GetMauSacs(string SP)
        {
            return sanPhamDAL.GetMauSacs(SP);
        }
        public bool them(San_Pham s)
        {

            try
            {
                return sanPhamDAL.them(s);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(San_Pham SP)
        {
            try
            {
                return sanPhamDAL.Update(SP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(string SP)
        {

            try
            {
                return sanPhamDAL.Delete(SP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal IEnumerable<SanPhamModelView> TimKiemTheoTenSP(string timKiem)
        {
            return sanPhamDAL.TimKiemTheoTenSP(timKiem);
        }

        internal IEnumerable<SanPhamModelView> TimKiemTheoMaSP(string timKiem)
        {
            return sanPhamDAL.TimKiemTheoMaSP(timKiem);
        }

        internal IEnumerable<SanPhamModelView> TimKiemTheoHangSP(string timKiem)
        {
            return sanPhamDAL.TimKiemTheoHangSP(timKiem);
        }
    }
}
