namespace NewQLTV.Models
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
        [Display(Name = "Mã mượn trả")]
        public int MAMUONTRA { get; set; }

        [Display(Name = "Mã sách")]
        public int? MASACH { get; set; }

        [Display(Name = "Đã trả")]
        public int DA_TRA { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày trả")]
        public DateTime? NGAYTRA { get; set; }
    }
}
