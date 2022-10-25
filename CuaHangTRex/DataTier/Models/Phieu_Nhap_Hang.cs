namespace CuaHangTRex.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phieu_Nhap_Hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieu_Nhap_Hang()
        {
            CT_NhapHang = new HashSet<CT_NhapHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaPhieuNhapHang { get; set; }

        public DateTime NgayLap { get; set; }

        [Required]
        [StringLength(11)]
        public string MaNVLap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_NhapHang> CT_NhapHang { get; set; }

        public virtual Nhan_Vien Nhan_Vien { get; set; }
    }
}
