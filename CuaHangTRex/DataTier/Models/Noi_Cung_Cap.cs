namespace CuaHangTRex.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Noi_Cung_Cap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Noi_Cung_Cap()
        {
            San_Pham = new HashSet<San_Pham>();
        }

        [Key]
        [StringLength(5)]
        public string MaNCC { get; set; }

        [StringLength(50)]
        public string TenNCC { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<San_Pham> San_Pham { get; set; }
    }
}
