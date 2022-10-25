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
    internal class NhanHangBUS
    {
        private NhanHangDAL nhanHangDAL;

        public NhanHangBUS()
        {
            nhanHangDAL = new NhanHangDAL();
        }

        public IEnumerable<Chung_Loai> GetNhanHangs()
        {
            return nhanHangDAL.GetNhanHangs();
        }

    }
}

