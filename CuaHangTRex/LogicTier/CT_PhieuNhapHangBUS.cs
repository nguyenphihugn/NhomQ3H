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
    internal class CT_PhieuNhapHangBUS
    {
        private CT_PhieuNhapHangDAL cT_PhieuNhapHangDAL;

        public CT_PhieuNhapHangBUS()
        {
            cT_PhieuNhapHangDAL = new CT_PhieuNhapHangDAL();
        }

        public IEnumerable<CT_PhieuNhapHangModel> GetNhapHangs()
        {
            return cT_PhieuNhapHangDAL.GetNhapHangs();
        }

        public bool themChiTiet(CT_NhapHang cT)
        {
            try
            {
                return cT_PhieuNhapHangDAL.themChiTiet(cT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool catNhatChiTiet(CT_NhapHang cT)
        {
            try
            {
                return cT_PhieuNhapHangDAL.catNhatChiTiet(cT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool xoaChiTiet(string MaSP, string MaP)
        {
            try
            {
                return cT_PhieuNhapHangDAL.xoaChiTiet(MaSP, MaP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal IEnumerable<CT_PhieuNhapHangModel> TimKiemTheoMaP(string timKiem)
        {
            return cT_PhieuNhapHangDAL.TimKiemTheoMaP(timKiem);
        }

        internal IEnumerable<CT_NhapKhoViewModel_Xuat> GetQuanLyCT_NhapKhoXuat(string MAPN)
        {
            return cT_PhieuNhapHangDAL.GetQuanLyCT_NhapKhoXuat(MAPN);
        }
    }
}
