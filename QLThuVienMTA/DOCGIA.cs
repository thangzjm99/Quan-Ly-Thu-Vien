namespace QLThuVienMTA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCGIA")]
    public partial class DOCGIA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASINHVIEN { get; set; }

        [StringLength(100)]
        public string TENDOCGIA { get; set; }

        [StringLength(100)]
        public string GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(100)]
        public string LOP { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        public int? MATHETV { get; set; }
    }
}
