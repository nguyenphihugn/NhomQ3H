using CuaHangTRex.DataTier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRex.ViewModel
{
    internal class HoaDonViewModel
    {
        public string MaHD { get; set; }

        public DateTime NgayLapHD { get; set; }

        public long TongTien { get; set; }
        public long GiamGia { get; set; }

        public string MaKH { get; set; }

        public string MaNVLap { get; set; }


    }
}