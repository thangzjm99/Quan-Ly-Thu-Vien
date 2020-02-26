namespace QLThuVienMTA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUONSACK")]
    public partial class MUONSACK
    {
        public int? MAMUONTRA { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATHETV { get; set; }

        public int? MASINHVIEN { get; set; }

        public int? MASACH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYMUON { get; set; }
    }
}
