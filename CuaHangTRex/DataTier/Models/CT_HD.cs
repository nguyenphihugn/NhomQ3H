namespace CuaHangTRex.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        public int SL_Mua { get; set; }

        public virtual Hoa_Don Hoa_Don { get; set; }

        public virtual San_Pham San_Pham { get; set; }
    }
}
