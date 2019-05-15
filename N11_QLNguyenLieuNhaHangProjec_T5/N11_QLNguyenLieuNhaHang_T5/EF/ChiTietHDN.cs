namespace N11_QLNguyenLieuNhaHang_T5.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHDN")]
    public partial class ChiTietHDN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNL { get; set; }

        public int GiaTien { get; set; }

        public double SoLuong { get; set; }

        public virtual HoaDonNhapNL HoaDonNhapNL { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
