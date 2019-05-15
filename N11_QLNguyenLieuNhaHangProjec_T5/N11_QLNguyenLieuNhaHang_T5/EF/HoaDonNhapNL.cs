namespace N11_QLNguyenLieuNhaHang_T5.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonNhapNL")]
    public partial class HoaDonNhapNL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDonNhapNL()
        {
            ChiTietHDNs = new HashSet<ChiTietHDN>();
        }

        [Key]
        public int MaHDN { get; set; }

        public int? MaPDNL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public int? MaNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDN> ChiTietHDNs { get; set; }

        public virtual PhieuDatNL PhieuDatNL { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
