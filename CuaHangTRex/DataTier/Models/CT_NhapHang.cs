namespace CuaHangTRex.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_NhapHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPhieuNhapHang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        public int SL_Nhap { get; set; }

        public long DonGiaNhap { get; set; }

        public virtual Phieu_Nhap_Hang Phieu_Nhap_Hang { get; set; }

        public virtual San_Pham San_Pham { get; set; }
    }
}
