namespace CuaHangTRex.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hoa_Don
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoa_Don()
        {
            CT_HD = new HashSet<CT_HD>();
        }

        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        public DateTime NgayLapHD { get; set; }

        public long GiamGia { get; set; }

        public long TongTien { get; set; }

        [Required]
        [StringLength(11)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(11)]
        public string MaNVLap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HD> CT_HD { get; set; }

        public virtual Khach_Hang Khach_Hang { get; set; }

        public virtual Nhan_Vien Nhan_Vien { get; set; }
    }
}
