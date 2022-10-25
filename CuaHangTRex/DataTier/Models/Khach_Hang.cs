namespace CuaHangTRex.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Khach_Hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khach_Hang()
        {
            Hoa_Don = new HashSet<Hoa_Don>();
        }

        [Key]
        [StringLength(11)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(30)]
        public string TenKH { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(60)]
        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoa_Don> Hoa_Don { get; set; }
    }
}
