namespace CuaHangTRex.DataTier.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nhan_Vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nhan_Vien()
        {
            Hoa_Don = new HashSet<Hoa_Don>();
            Phieu_Nhap_Hang = new HashSet<Phieu_Nhap_Hang>();
        }

        [Key]
        [StringLength(11)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(30)]
        public string TenNV { get; set; }

        [Required]
        [StringLength(10)]
        public string Gioi_Tinh { get; set; }

        public DateTime Ngay_Sinh { get; set; }

        [Required]
        [StringLength(11)]
        public string SDT { get; set; }

        public DateTime Ngay_Vao_Lam { get; set; }

        [Required]
        [StringLength(30)]
        public string TinhTrangHoatDong { get; set; }

        [Required]
        [StringLength(20)]
        public string ChucVu { get; set; }

        [Required]
        [StringLength(20)]
        public string TenTK { get; set; }

        [Required]
        [StringLength(20)]
        public string MK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoa_Don> Hoa_Don { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Nhap_Hang> Phieu_Nhap_Hang { get; set; }
    }
}
