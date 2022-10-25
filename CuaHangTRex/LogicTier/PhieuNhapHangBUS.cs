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
    internal class PhieuNhapHangBUS
    {
        private PhieuNhapHangDAL phieuNhapHangDAL;

        public PhieuNhapHangBUS()
        {
            phieuNhapHangDAL = new PhieuNhapHangDAL();
        }
        public IEnumerable<NhapHangModel> GetNhapHangs()
        {
            return phieuNhapHangDAL.GetNhapHangs();
        }

        public bool GetNhapHangTimKiem(string pnh)
        {
            try
            {
                return phieuNhapHangDAL.GetNhapHangTimKiem(pnh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemPhieuNhapHang(Phieu_Nhap_Hang pnh)
        {
            // try
            //{
            return phieuNhapHangDAL.ThemPhieuNhapHang(pnh);
            // }
            // catch (Exception ex)
            // {
            //    throw ex;
            // }
        }

        public bool suaPhieuNhapHang(Phieu_Nhap_Hang pnh)
        {
            try
            {
                return phieuNhapHangDAL.suaPhieuNhapHang(pnh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool xoaPhieuNhapHang(string maPhieuNhapHang, string MaNVLAP)
        {
            try
            {
                return phieuNhapHangDAL.xoaPhieuNhapHang(maPhieuNhapHang, MaNVLAP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal IEnumerable<NhapHangModel> GetTruyXuats(int thang, int nam)
        {
            return phieuNhapHangDAL.GetTruyXuats(thang, nam);
        }
    }
}
