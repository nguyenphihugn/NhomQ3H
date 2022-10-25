using CuaHangTRex.DataTier.Models;
using CuaHangTRex.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRex.DataTier
{
    internal class NhanHangDAL
    {
        private QuanLyShopGiayModels quanLyShopGiayModels;

        public NhanHangDAL()
        {
            quanLyShopGiayModels = new QuanLyShopGiayModels();
        }
        public IEnumerable<Chung_Loai> GetNhanHangs()
        {
            return quanLyShopGiayModels.Chung_Loai.ToList();
        }
    }
}

