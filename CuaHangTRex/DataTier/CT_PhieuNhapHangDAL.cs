using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRex.DataTier
{
    internal class CT_PhieuNhapHangDAL
    {
        private QuanLyShopGiayModels nhapHangContexts;

        public CT_PhieuNhapHangDAL()
        {
            nhapHangContexts = new QuanLyShopGiayModels();
        }


        public IEnumerable<CT_PhieuNhapHangModel> GetNhapHangs()
        {
            var danhSach = nhapHangContexts.CT_NhapHang.Select(x => new CT_PhieuNhapHangModel()
            {
                MaPhieuNhapHang = x.MaPhieuNhapHang,
                MaSP = x.MaSP,
                SL_Nhap = x.SL_Nhap,
                DonGiaNhap = x.DonGiaNhap,
            }).ToList();
            return danhSach;
        }

        public bool themChiTiet(CT_NhapHang cT)
        {
            try
            {
                CT_NhapHang chiTiet = nhapHangContexts.CT_NhapHang.Where(x => x.MaPhieuNhapHang == cT.MaPhieuNhapHang && x.MaSP == cT.MaSP).FirstOrDefault();
                if (cT.MaSP.Length > 10)
                    throw new Exception("Mã sản phẩm không được quá 10 kí tự!!!");
                if (chiTiet != null)
                    throw new Exception("Chi tiết sản phẩm đã tồn tại!");
                nhapHangContexts.CT_NhapHang.Add(cT);
                nhapHangContexts.SaveChanges();
                return true;
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
                CT_NhapHang chiTiet = nhapHangContexts.CT_NhapHang.Where(x => x.MaPhieuNhapHang == cT.MaPhieuNhapHang && x.MaSP == cT.MaSP).FirstOrDefault();
                if (chiTiet == null)
                {
                    throw new Exception("Mã phiếu không tồn tại");
                }
                if (cT.MaSP.Length > 10) 
                    throw new Exception("Mã sản phẩm không được quá 10 kí tự!!!");
                else
                {
                    chiTiet.SL_Nhap = cT.SL_Nhap;
                    chiTiet.DonGiaNhap = cT.DonGiaNhap;
                    nhapHangContexts.SaveChanges();
                }
                return true;
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
                CT_NhapHang xoa = nhapHangContexts.CT_NhapHang.Where(x => x.MaPhieuNhapHang == MaP && x.MaSP == MaSP).FirstOrDefault();
                if (xoa == null)
                {
                    throw new Exception(" Mã phiếu không tồn tại!");
                }
                nhapHangContexts.CT_NhapHang.Remove(xoa);
                nhapHangContexts.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        internal IEnumerable<CT_PhieuNhapHangModel> TimKiemTheoMaP(string timKiem)
        {
            return nhapHangContexts.CT_NhapHang
                .Where(x => x.MaPhieuNhapHang == timKiem)
                .Select(x => new CT_PhieuNhapHangModel()
                {
                    MaPhieuNhapHang = x.MaPhieuNhapHang,
                    MaSP = x.MaSP,
                    SL_Nhap = x.SL_Nhap,
                    DonGiaNhap = x.DonGiaNhap,
                }).ToList();
        }

        public IEnumerable<CT_NhapKhoViewModel_Xuat> GetQuanLyCT_NhapKhoXuat(string Ma)
        {
            var danhSachHDs = nhapHangContexts.CT_NhapHang.Where(x => x.MaPhieuNhapHang == Ma).Select(x => new CT_NhapKhoViewModel_Xuat()
            {
                TenSanPham = x.San_Pham.TenSP,
                SL_Nhap = x.SL_Nhap,
                DonGiaNhap = x.DonGiaNhap,
            }).ToList();
            return danhSachHDs;
        }
    }
}
