namespace N11_QLNguyenLieuNhaHang_T5.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietBBTL")]
    public partial class ChiTietBBTL
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBB { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNL { get; set; }

        public int Gia { get; set; }

        public double SoLuong { get; set; }

        public virtual BienBanThanhLy BienBanThanhLy { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
