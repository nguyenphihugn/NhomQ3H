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
    internal class NoiCungCapBUS
    {
        private NoiCungCapDAL noiCungCapDAL;

        public NoiCungCapBUS()
        {
            noiCungCapDAL = new NoiCungCapDAL();
        }

        public IEnumerable<NoiCungCapViewModel> GetNoi_Cung_Caps()
        {
            return noiCungCapDAL.GetNoi_Cung_Caps();
        }


        internal IEnumerable<NoiCungCapViewModel> TimKiem(string timKiem)
        {
            return noiCungCapDAL.TimKiem(timKiem);
        }


        public bool them(Noi_Cung_Cap s)
        {

            try
            {
                return noiCungCapDAL.them(s);
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
                return noiCungCapDAL.Update(s);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(string s)
        {

            try
            {
                return noiCungCapDAL.Delete(s);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
