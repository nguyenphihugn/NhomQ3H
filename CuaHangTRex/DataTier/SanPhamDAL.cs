using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRex.DataTier
{
    internal class SanPhamDAL
    {
        private QuanLyShopGiayModels quanLyShopGiayModels;
        public SanPhamDAL()
        {
            quanLyShopGiayModels = new QuanLyShopGiayModels();
        }
        public IEnumerable<SanPhamViewModel> GetSan_Phams()
        {
            var DanhSach = quanLyShopGiayModels.San_Pham.Select(x => new SanPhamViewModel()
            {
                MaSP = x.MaSP,
                TenSP = x.TenSP,
                Size = x.Size,
                MauSac = x.MauSac,
                Don_Gia_Ban = x.Don_Gia_Ban,
                Tinh_Trang_SP = x.Tinh_Trang_SP,
                SL_TonKho = x.SL_TonKho,
                MaNCC = x.MaNCC,
                MaLoai = x.MaLoai
            }).ToList();
            return DanhSach;
        }
        public IEnumerable<SanPhamModelView> GetSan_PhamViews()
        {
            var DanhSachView = quanLyShopGiayModels.San_Pham.Select(x => new SanPhamModelView()
            {
                MaSP = x.MaSP,
                TenSP = x.TenSP,
                Size = x.Size,
                MauSac = x.MauSac,


                SL_TonKho = x.SL_TonKho,

                TenLoai = x.Chung_Loai.TenLoaiSP
            }).ToList();
            return DanhSachView;
        }
        public IEnumerable<San_Pham> GetSanPhams()
        {
            return quanLyShopGiayModels.San_Pham.ToList();
        }
        public IEnumerable<San_Pham> GetMauSacs(string SP)
        {
            return quanLyShopGiayModels.San_Pham.Where(s => s.MaSP == SP).ToList();
        }
        public bool them(San_Pham s)
        {
            try
            {
                San_Pham sanPham = quanLyShopGiayModels.San_Pham.Where(x => x.MaSP == s.MaSP).FirstOrDefault();
                San_Pham sanPhams = quanLyShopGiayModels.San_Pham.Where(x => x.TenSP == s.TenSP
                                                                        && x.Size == s.Size
                                                                        && x.MauSac == s.MauSac
                                                                        && x.MaLoai == s.MaLoai).FirstOrDefault();
                if (sanPham != null)
                {
                    throw new Exception("Sản Phẩm đã tồn tại!!!");
                }
                if (sanPhams != null)
                {
                    throw new Exception("Sản Phẩm đã tồn tại và đã có nhà cung cấp!!!");
                }
                if (s.Don_Gia_Ban < 0)
                {
                    throw new Exception("Đơn giá bán phải lớn hơn hoặc bằng 0!!!");
                }
                if (s.Size <= 0)
                {
                    throw new Exception("Size phải lớn hơn 0!!!");
                }
                if (s.SL_TonKho < 0)
                {
                    throw new Exception("Số lượng tồn kho phải lớn hơn hoặc bằng 0!!!");
                }
                if (s.MaSP.Length > 10)
                    throw new Exception("Mã sản phẩm không được quá 10 kí tự!!!");
                if (s.TenSP.Length > 50)
                    throw new Exception("Tên sản phẩm không được quá 50 kí tự!!!");
                if (s.MauSac.Length > 20)
                    throw new Exception("Màu sắc không được quá 20 kí tự!!!");

                quanLyShopGiayModels.San_Pham.Add(s);
                quanLyShopGiayModels.SaveChanges();

                return true;
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
                San_Pham sanPham = quanLyShopGiayModels.San_Pham.Where(x => x.MaSP == SP.MaSP).FirstOrDefault();
                San_Pham sanPhams = quanLyShopGiayModels.San_Pham.Where(x => x.TenSP == SP.TenSP
                                                                        && x.Size == SP.Size
                                                                        && x.MauSac == SP.MauSac
                                                                        && x.MaLoai == SP.MaLoai).FirstOrDefault();
                if (sanPham == null)
                    throw new Exception("Sản Phẩm không tồn tại!!!");
                if (SP.MaSP.Length > 10)
                    throw new Exception("Mã sản phẩm không được quá 10 kí tự!!!");
                if (SP.TenSP.Length > 50)
                    throw new Exception("Tên sản phẩm không được quá 50 kí tự!!!");
                if (SP.MauSac.Length > 20)
                    throw new Exception("Màu sắc không được quá 20 kí tự!!!");
                if (sanPhams != null && sanPhams != sanPham)
                {
                    throw new Exception("Sản Phẩm đã tồn tại và đã có nhà cung cấp!!!");
                }
                if (SP.Don_Gia_Ban < 0)
                {
                    throw new Exception("Đơn giá bán phải lớn hơn hoặc bằng 0!!!");
                }
                if (SP.Size <= 0)
                {
                    throw new Exception("Size phải lớn hơn 0!!!");
                }
                if (SP.SL_TonKho < 0)
                {
                    throw new Exception("Số lượng tồn kho phải lớn hơn hoặc bằng 0!!!");
                }
                
                else
                {
                    sanPham.TenSP = SP.TenSP;
                    sanPham.MauSac = SP.MauSac;
                    sanPham.Size = SP.Size;
                    sanPham.Don_Gia_Ban = SP.Don_Gia_Ban;
                    sanPham.Tinh_Trang_SP = SP.Tinh_Trang_SP;
                    sanPham.SL_TonKho = SP.SL_TonKho;
                    sanPham.MaNCC = SP.MaNCC;
                    sanPham.MaLoai = SP.MaLoai;
                    quanLyShopGiayModels.SaveChanges();
                }
                return true;
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
                CT_HD T = quanLyShopGiayModels.CT_HD.Where(x => x.MaSP == SP).FirstOrDefault();
                CT_NhapHang D = quanLyShopGiayModels.CT_NhapHang.Where(x => x.MaSP == SP).FirstOrDefault();
                San_Pham sanPham = quanLyShopGiayModels.San_Pham.Where(x => x.MaSP == SP).FirstOrDefault();
                if (sanPham == null)
                {
                    throw new Exception("Sản Phẩm không tồn tại!!!");
                }
                if (D != null || T != null)
                {
                    throw new Exception("Sản Phẩm không thể xóa!!!");

                }
                else
                {
                    quanLyShopGiayModels.San_Pham.Remove(sanPham);
                    quanLyShopGiayModels.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal IEnumerable<SanPhamModelView> TimKiemTheoTenSP(string timKiem)
        {
            return quanLyShopGiayModels.San_Pham
                .Where(x => x.TenSP.ToLower().Contains(timKiem))
                .Select(x => new SanPhamModelView()
                {
                    MaSP = x.MaSP,
                    TenSP = x.TenSP,
                    Size = x.Size,
                    MauSac = x.MauSac,
                    SL_TonKho = x.SL_TonKho,
                    TenLoai = x.Chung_Loai.TenLoaiSP
                }).ToList();
        }

        internal IEnumerable<SanPhamModelView> TimKiemTheoMaSP(string timKiem)
        {
            return quanLyShopGiayModels.San_Pham
                .Where(x => x.MaSP.ToLower().Contains(timKiem))
                .Select(x => new SanPhamModelView()
                {
                    MaSP = x.MaSP,
                    TenSP = x.TenSP,
                    Size = x.Size,
                    MauSac = x.MauSac,
                    SL_TonKho = x.SL_TonKho,
                    TenLoai = x.Chung_Loai.TenLoaiSP
                }).ToList();
        }

        internal IEnumerable<SanPhamModelView> TimKiemTheoHangSP(string timKiem)
        {
            return quanLyShopGiayModels.San_Pham
                .Where(x => x.MaLoai.Contains(timKiem))
                .Select(x => new SanPhamModelView()
                {
                    MaSP = x.MaSP,
                    TenSP = x.TenSP,
                    Size = x.Size,
                    MauSac = x.MauSac,
                    SL_TonKho = x.SL_TonKho,
                    TenLoai = x.Chung_Loai.TenLoaiSP
                }).ToList();
        }
    }
}
