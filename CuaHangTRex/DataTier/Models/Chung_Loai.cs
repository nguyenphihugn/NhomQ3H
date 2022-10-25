namespace CuaHangTRex.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Chung_Loai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chung_Loai()
        {
            San_Pham = new HashSet<San_Pham>();
        }

        [Key]
        [StringLength(5)]
        public string MaLoai { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiSP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<San_Pham> San_Pham { get; set; }
    }
}
