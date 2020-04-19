namespace NewQLTV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUONSACK")]
    public partial class MUONSACK
    {
        [Display(Name = "Mã mượn trả")]
        public int? MAMUONTRA { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
         [Display(Name = "Mã thẻ thành viên")]
        public int MATHETV { get; set; }

        [Display(Name = "Mã sinh viên")]
        public int? MASINHVIEN { get; set; }

        [Display(Name = "Mã sách")]
        public int? MASACH { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày mượn")]
        public DateTime? NGAYMUON { get; set; }
    }
}
