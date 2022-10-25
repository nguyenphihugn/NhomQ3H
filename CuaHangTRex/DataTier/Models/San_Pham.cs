namespace CuaHangTRex.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class San_Pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public San_Pham()
        {
            CT_HD = new HashSet<CT_HD>();
            CT_NhapHang = new HashSet<CT_NhapHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        public double Size { get; set; }

        [Required]
        [StringLength(20)]
        public string MauSac { get; set; }

        public long Don_Gia_Ban { get; set; }

        [StringLength(20)]
        public string Tinh_Trang_SP { get; set; }

        public int? SL_TonKho { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(5)]
        public string MaLoai { get; set; }

        public virtual Chung_Loai Chung_Loai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HD> CT_HD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_NhapHang> CT_NhapHang { get; set; }

        public virtual Noi_Cung_Cap Noi_Cung_Cap { get; set; }
    }
}
