using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRex.DataTier
{
    internal class NoiCungCapDAL
    {
        private QuanLyShopGiayModels quanLyShopGiayModels;

        public NoiCungCapDAL()
        {
            quanLyShopGiayModels = new QuanLyShopGiayModels();
        }
        public IEnumerable<NoiCungCapViewModel> GetNoi_Cung_Caps()
        {
            var DanhSach = quanLyShopGiayModels.Noi_Cung_Cap.Select(x => new NoiCungCapViewModel()
            {
                MaNCC = x.MaNCC,
                TenNCC = x.TenNCC,
                SDT = x.SDT,
                Email = x.Email,
            }).ToList();
            return DanhSach;
        }


        internal IEnumerable<NoiCungCapViewModel> TimKiem(string timKiem)
        {

            string MaNCCs = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.MaNCC.ToLower().Contains(timKiem)).Select(x => x.MaNCC).FirstOrDefault();
            string TenNCCs = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.TenNCC.ToLower().Contains(timKiem)).Select(x => x.TenNCC).FirstOrDefault();
            string SDTs = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.SDT.ToLower().Contains(timKiem)).Select(x => x.SDT).FirstOrDefault();
            string Emails = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.Email.ToLower().Contains(timKiem)).Select(x => x.Email).FirstOrDefault();
            if (MaNCCs != null)
            {
                return quanLyShopGiayModels.Noi_Cung_Cap
                .Where(x => x.MaNCC.ToLower().Contains(timKiem)).Select(x => new NoiCungCapViewModel()
                {
                    MaNCC = x.MaNCC,
                    TenNCC = x.TenNCC,
                    SDT = x.SDT,
                    Email = x.Email,
                }).ToList();

            }
            else if (TenNCCs != null)
            {
                return quanLyShopGiayModels.Noi_Cung_Cap
                .Where(x => x.TenNCC.ToLower().Contains(timKiem)).Select(x => new NoiCungCapViewModel()
                {
                    MaNCC = x.MaNCC,
                    TenNCC = x.TenNCC,
                    SDT = x.SDT,
                    Email = x.Email,
                }).ToList();
            }
            else if (SDTs != null)
            {
                return quanLyShopGiayModels.Noi_Cung_Cap
                .Where(x => x.SDT.ToLower().Contains(timKiem)).Select(x => new NoiCungCapViewModel()
                {
                    MaNCC = x.MaNCC,
                    TenNCC = x.TenNCC,
                    SDT = x.SDT,
                    Email = x.Email,
                }).ToList();
            }
            else if (Emails != null)
            {
                return quanLyShopGiayModels.Noi_Cung_Cap
                .Where(x => x.Email.ToLower().Contains(timKiem)).Select(x => new NoiCungCapViewModel()
                {
                    MaNCC = x.MaNCC,
                    TenNCC = x.TenNCC,
                    SDT = x.SDT,
                    Email = x.Email,
                }).ToList();
            }
            else
            {
                return null;
            }


        }

        public bool them(Noi_Cung_Cap s)
        {
            try
            {
                Noi_Cung_Cap NoiCungCap = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.MaNCC == s.MaNCC).FirstOrDefault();
                Noi_Cung_Cap NoiCungCaps = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.TenNCC == s.TenNCC
                                                                        && x.SDT == s.SDT
                                                                        && x.Email == s.Email).FirstOrDefault();
                if (NoiCungCap != null)
                {
                    throw new Exception("Mã Nhà cung cấp này đã tồn tại!!!");
                }
                if (NoiCungCaps != null)
                {
                    throw new Exception("Thông tin Nhà cung cấp này đã tồn tại rồi!!!");
                }
                if (s.MaNCC.Length > 5)
                    throw new Exception("Mã nhà cung cấp không được quá 5 kí tự!!!");
                if (s.TenNCC.Length > 50)
                    throw new Exception("Tên nhà cung cấp không được quá 50 kí tự!!!");
                if (s.SDT.Length > 11)
                    throw new Exception("Số điện thoại không được quá 11 kí tự!!!");
                if (s.Email.Length > 50)
                    throw new Exception("Email không được quá 50 kí tự!!!");
                quanLyShopGiayModels.Noi_Cung_Cap.Add(s);
                quanLyShopGiayModels.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Noi_Cung_Cap s)
        {

            try
            {
                Noi_Cung_Cap NoiCungCap = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.MaNCC == s.MaNCC).FirstOrDefault();
                //Noi_Cung_Cap H = NoiCungCap;
                Noi_Cung_Cap NoiCungCaps = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.TenNCC == s.TenNCC
                                                                                    && x.SDT == s.SDT
                                                                                    && x.Email == s.Email).FirstOrDefault();

                string NoiCungCapTenNCC = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.TenNCC == s.TenNCC
                                                                                    && x.SDT == NoiCungCap.SDT
                                                                                    && x.Email == NoiCungCap.Email).Select(Z => Z.MaNCC).FirstOrDefault();

                string NoiCungCapSĐTNCC = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.TenNCC == NoiCungCap.TenNCC
                                                                                    && x.SDT == s.SDT
                                                                                    && x.Email == NoiCungCap.Email).Select(Z => Z.MaNCC).FirstOrDefault();

                string NoiCungCapEmailNCC = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.TenNCC == NoiCungCap.TenNCC
                                                                                    && x.SDT == NoiCungCap.SDT
                                                                                    && x.Email == s.Email).Select(Z => Z.MaNCC).FirstOrDefault();

                string NoiCungCapTenVaSĐT = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.TenNCC == s.TenNCC
                                                                                    && x.SDT == s.SDT
                                                                                    && x.Email == NoiCungCap.Email).Select(Z => Z.MaNCC).FirstOrDefault();

                string NoiCungCapSĐTVaEmail = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.TenNCC == NoiCungCap.TenNCC
                                                                                    && x.SDT == s.SDT
                                                                                    && x.Email == s.Email).Select(Z => Z.MaNCC).FirstOrDefault();

                string NoiCungCapTenVaEmail = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.TenNCC == s.TenNCC
                                                                                    && x.SDT == NoiCungCap.SDT
                                                                                    && x.Email == s.Email).Select(Z => Z.MaNCC).FirstOrDefault();
                if (s.MaNCC.Length > 5)
                    throw new Exception("Mã nhà cung cấp không được quá 5 kí tự!!!");
                if (s.TenNCC.Length > 50)
                    throw new Exception("Tên nhà cung cấp không được quá 50 kí tự!!!");
                if (s.SDT.Length > 11)
                    throw new Exception("Số điện thoại không được quá 11 kí tự!!!");
                if (s.Email.Length > 50)
                    throw new Exception("Email không được quá 50 kí tự!!!");
                if (NoiCungCap == null)
                {
                    throw new Exception("Mã Nhà cung cấp này Chưa tồn tại!!!");
                }
                if (NoiCungCaps != null)
                {
                    throw new Exception("Thông tin Nhà cung cấp này đã tồn tại rồi!!!");
                }
                if (s.SDT == null || s.Email == null || s.TenNCC == null)
                {


                    if (NoiCungCapTenNCC != null || NoiCungCapSĐTNCC != null || NoiCungCapEmailNCC != null || NoiCungCapTenVaSĐT != null || NoiCungCapSĐTVaEmail != null || NoiCungCapTenVaEmail != null)
                    {
                        throw new Exception("Thông tin Nhà cung cấp này đã tồn tại rồi================!!!");
                    }
                }



                if (s.TenNCC != null && s.SDT != null && s.Email != null)
                {
                    NoiCungCap.TenNCC = s.TenNCC;
                    NoiCungCap.SDT = s.SDT;
                    NoiCungCap.Email = s.Email;
                }
                if (s.TenNCC != null && s.SDT == null && s.Email == null)
                {
                    NoiCungCap.TenNCC = s.TenNCC;

                }
                else if (s.TenNCC == null && s.SDT != null && s.Email == null)
                {
                    NoiCungCap.SDT = s.SDT;
                }
                else if (s.TenNCC == null && s.SDT == null && s.Email != null)
                {
                    NoiCungCap.Email = s.Email;
                }
                else if (s.TenNCC != null && s.SDT != null && s.Email == null)
                {
                    NoiCungCap.TenNCC = s.TenNCC;
                    NoiCungCap.SDT = s.SDT;
                }
                else if (s.TenNCC == null && s.SDT != null && s.Email != null)
                {
                    NoiCungCap.SDT = s.SDT;
                    NoiCungCap.Email = s.Email;
                }
                else if (s.TenNCC != null && s.SDT == null && s.Email != null)
                {
                    NoiCungCap.TenNCC = s.TenNCC;

                    NoiCungCap.Email = s.Email;
                }
                quanLyShopGiayModels.SaveChanges();

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
                San_Pham sanPham = quanLyShopGiayModels.San_Pham.Where(x => x.MaNCC == SP).FirstOrDefault();
                Noi_Cung_Cap noiCungCap = quanLyShopGiayModels.Noi_Cung_Cap.Where(x => x.MaNCC == SP).FirstOrDefault();
                if (noiCungCap == null)
                {
                    throw new Exception("Nhà cung cấp không tồn tại!!!");
                }
                if (sanPham != null)
                {
                    throw new Exception("Nhà cung cấp này không thể xóa, Vì còn cần dùng lưu dữ liệu!!!");
                }
                else
                {
                    quanLyShopGiayModels.Noi_Cung_Cap.Remove(noiCungCap);
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
