namespace NewQLTV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONGSACH")]
    public partial class DONGSACH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Display(Name = "Mã sách")]
        public int MASACH { get; set; }

        [StringLength(100)]
        [Display(Name = "Tên sách")]
        public string TENSACH { get; set; }

        [StringLength(100)]
        [Display(Name = "Tác giả")]
        public string TACGIA { get; set; }

        [Display(Name = "Số trang")]
        public int? SOTRANG { get; set; }

        [StringLength(100)]
        [Display(Name = "Thể loại")]
        public string THELOAI { get; set; }

        [StringLength(100)]
        [Display(Name = "Tình trạng")]
        public string TINHTRANG { get; set; }

        [StringLength(100)]
        [Display(Name = "Nhà xuất bản")]
        public string NHAXUATBAN { get; set; }

        [StringLength(100)]
        [Display(Name = "Năm xuất bản")]
        public string NAMXUATBAN { get; set; }
    }
}
