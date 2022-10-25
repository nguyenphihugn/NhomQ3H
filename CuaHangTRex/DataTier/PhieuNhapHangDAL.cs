using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTRex.DataTier
{
    internal class PhieuNhapHangDAL
    {
        private QuanLyShopGiayModels nhapHangContexts;

        public PhieuNhapHangDAL()
        {
            nhapHangContexts = new QuanLyShopGiayModels();
        }

        public IEnumerable<NhapHangModel> GetNhapHangs()
        {
            var danhSach = nhapHangContexts.Phieu_Nhap_Hang.Select(x => new NhapHangModel()
            {
                MaPhieuNhapHang = x.MaPhieuNhapHang,
                MaNVLap = x.MaNVLap,
                NgayLap = x.NgayLap,
            }).ToList();
            return danhSach;
        }

        public bool GetNhapHangTimKiem(string pnh)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                if(pnh == "")
                {
                    throw new Exception("Chưa Chọn Mã Phiếu!");
                }
                Phieu_Nhap_Hang xoa = nhapHangContexts.Phieu_Nhap_Hang.Where(x => x.MaPhieuNhapHang == pnh).FirstOrDefault();
                if (dateTime.Month != xoa.NgayLap.Month || dateTime.Year != xoa.NgayLap.Year)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemPhieuNhapHang(Phieu_Nhap_Hang pnh)
        {
            try
            {
                DateTime dt = DateTime.Now;
                Nhan_Vien nv = nhapHangContexts.Nhan_Vien.Where(x => x.MaNV == pnh.MaNVLap).FirstOrDefault();
                Phieu_Nhap_Hang capNhatHang = nhapHangContexts.Phieu_Nhap_Hang.Where(x => x.MaPhieuNhapHang == pnh.MaPhieuNhapHang).FirstOrDefault();
                if (pnh.MaPhieuNhapHang.Length > 10)
                    throw new Exception("Mã phiếu không được quá 10 kí tự!!!");
                if (pnh.NgayLap >= dt)
                {
                    throw new Exception("Ngày lập không hợp lệ!");
                }

                if (capNhatHang != null)
                {
                    throw new Exception("Ma phiếu đã tồn tại!!!");
                }
                if (nv == null)
                {
                    throw new Exception("Nhân viên lập không tồn tại!!!");
                }
                try
                {
                    var emp = nhapHangContexts.Phieu_Nhap_Hang.Add(pnh);
                    nhapHangContexts.Entry(emp).State = System.Data.Entity.EntityState.Added;
                    //nhapHangContexts.Database.Log = s => Console.WriteLine(s);
                    nhapHangContexts.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return true;
                }

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
                DateTime dt = DateTime.Now;
                CT_NhapHang ct = nhapHangContexts.CT_NhapHang.Where(x => x.MaPhieuNhapHang == maPhieuNhapHang).FirstOrDefault();
                Phieu_Nhap_Hang xoa = nhapHangContexts.Phieu_Nhap_Hang.Where(x => x.MaPhieuNhapHang == maPhieuNhapHang).FirstOrDefault();
                if (xoa == null)
                {
                    throw new Exception(" Ma phiếu không tồn tại!");
                }
                if (ct != null)
                {
                    DialogResult dlr = MessageBox.Show("Mã phiếu còn dùng đẻ lưu thông tin chi tiết! Bạn có chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dlr == DialogResult.No)
                    {
                        throw new Exception("Đã dừng xóa");
                    }

                }
                if(dt.Month != xoa.NgayLap.Month || dt.Year != xoa.NgayLap.Year )
                {
                    throw new Exception("Không thể xóa Phiếu Nhập đã lập quá 1 tháng!!!");
                }
                if(xoa.MaNVLap == null)
                {
                    xoa.MaNVLap = MaNVLAP;
                    //nhapHangContexts.SaveChanges();
                }
                try
                {
                    nhapHangContexts.Phieu_Nhap_Hang.Remove(xoa);
                    nhapHangContexts.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool suaPhieuNhapHang(Phieu_Nhap_Hang pnh)
        {
            try
            {
                Nhan_Vien nv = nhapHangContexts.Nhan_Vien.Where(x => x.MaNV == pnh.MaNVLap).FirstOrDefault();
                Phieu_Nhap_Hang nh = nhapHangContexts.Phieu_Nhap_Hang.Where(x => x.MaPhieuNhapHang == pnh.MaPhieuNhapHang).FirstOrDefault();
                if (nh == null)
                {
                    throw new Exception("Mã phiếu không tồn tại");
                }
                else if (nv == null)
                {
                    throw new Exception("Nhân viên lập không tồn tại!!!");
                }
                else
                {
                    nh.NgayLap = pnh.NgayLap;
                    nh.MaNVLap = pnh.MaNVLap;
                    nhapHangContexts.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        internal IEnumerable<NhapHangModel> GetTruyXuats(int thang, int nam)
        {
            return nhapHangContexts.Phieu_Nhap_Hang.Where(x => x.NgayLap.Month == thang && x.NgayLap.Year == nam).Select(x => new NhapHangModel()
            {
                MaPhieuNhapHang = x.MaPhieuNhapHang,
                MaNVLap = x.MaNVLap,
                NgayLap = x.NgayLap,
            }).ToList();
            
        }
    }
}
