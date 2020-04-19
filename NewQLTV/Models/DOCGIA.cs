namespace NewQLTV.Models
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
        [Display(Name ="Mã sinh viên")]
        public int MASINHVIEN { get; set; }

        [StringLength(100)]
        [Display(Name = "Tên độc giả")]
        public string TENDOCGIA { get; set; }

        [StringLength(100)]
        [Display(Name = "Giới tính")]
        public string GIOITINH { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày sinh")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(100)]
        [Display(Name = "Lớp")]
        public string LOP { get; set; }

        [StringLength(100)]
        [Display(Name = "Địa chỉ")]
        public string DIACHI { get; set; }

        [Display(Name = "Mã thẻ thành viên")]
        public int? MATHETV { get; set; }
    }
}
