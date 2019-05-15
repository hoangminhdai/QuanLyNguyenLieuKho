namespace N11_QLNguyenLieuNhaHang_T5.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPTK")]
    public partial class ChiTietPTK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPTK { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNL { get; set; }

        public double SoLuong { get; set; }

        public virtual PhieuThongKe PhieuThongKe { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
