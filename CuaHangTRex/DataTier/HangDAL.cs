using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRex.DataTier
{
    internal class HangDAL
    {
        private QuanLyShopGiayModels quanLyShopGiayModels;
        public HangDAL()
        {
            quanLyShopGiayModels = new QuanLyShopGiayModels();
        }

        public IEnumerable<HangViewModel> GetChung_Loais()
        {
            var DanhSach = quanLyShopGiayModels.Chung_Loai.Select(x => new HangViewModel()
            {
                MaLoai = x.MaLoai,
                TenLoaiSP = x.TenLoaiSP,
            }).ToList();
            return DanhSach;
        }

        public bool them(Chung_Loai s)
        {
            try
            {
                Chung_Loai hang = quanLyShopGiayModels.Chung_Loai.Where(x => x.MaLoai == s.MaLoai).FirstOrDefault();
                Chung_Loai hangs = quanLyShopGiayModels.Chung_Loai.Where(x => x.TenLoaiSP == s.TenLoaiSP).FirstOrDefault();
                if (s.MaLoai.Length > 5)
                    throw new Exception("Mã loại không được quá 5 kí tự!!!");
                if (s.TenLoaiSP.Length > 50)
                    throw new Exception("Tên loại không được quá 50 kí tự!!!");
                if (hangs != null)
                {
                    throw new Exception("Tên Hãng đã tồn tại!!!");
                }
                if (hang == null)
                {
                    quanLyShopGiayModels.Chung_Loai.Add(s);
                    quanLyShopGiayModels.SaveChanges();
                }
                else
                {
                    hang.TenLoaiSP = s.TenLoaiSP;
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

                San_Pham sanPham = quanLyShopGiayModels.San_Pham.Where(x => x.MaLoai == SP).FirstOrDefault();
                Chung_Loai hang = quanLyShopGiayModels.Chung_Loai.Where(x => x.MaLoai == SP).FirstOrDefault();              
                if (hang == null)
                {
                    throw new Exception("Sản Phẩm không tồn tại!!!");
                }
                if (sanPham != null)
                {
                    throw new Exception("Hãng không thể xóa, Vì còn cần dùng lưu dữ liệu!!!");

                }
                else
                {
                    quanLyShopGiayModels.Chung_Loai.Remove(hang);
                    quanLyShopGiayModels.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
