namespace N11_QLNguyenLieuNhaHang_T5.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguyenLieu")]
    public partial class NguyenLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguyenLieu()
        {
            ChiTietBBTLs = new HashSet<ChiTietBBTL>();
            ChiTietHDNs = new HashSet<ChiTietHDN>();
            ChiTietPDNLs = new HashSet<ChiTietPDNL>();
            ChiTietPTKs = new HashSet<ChiTietPTK>();
        }

        [Key]
        public int MaNL { get; set; }

        [StringLength(30)]
        public string TenNL { get; set; }

        public bool? LoaiTuoiKho { get; set; }

        public int? GiaTien { get; set; }

        public double? SoLuong { get; set; }

        [StringLength(30)]
        public string TenDonVi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBBTL> ChiTietBBTLs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDN> ChiTietHDNs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPDNL> ChiTietPDNLs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPTK> ChiTietPTKs { get; set; }
    }
}
