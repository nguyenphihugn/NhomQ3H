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
    internal class HangBUS
    {
        private HangDAL hangDAL;

        public HangBUS()
        {
            hangDAL = new HangDAL();
        }
        public IEnumerable<HangViewModel> GetChung_Loais()
        {
            return hangDAL.GetChung_Loais();
        }

        public void them(Chung_Loai s)
        {
            hangDAL.them(s);
        }
        public bool Delete(string SP)
        {

            try
            {
                return hangDAL.Delete(SP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
