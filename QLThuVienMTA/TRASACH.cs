namespace QLThuVienMTA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRASACH")]
    public partial class TRASACH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAMUONTRA { get; set; }

        public int? MASACH { get; set; }

        public int DA_TRA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTRA { get; set; }
    }
}
