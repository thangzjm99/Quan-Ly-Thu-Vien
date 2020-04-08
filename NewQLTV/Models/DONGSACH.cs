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
        public int MASACH { get; set; }

        [StringLength(100)]
        public string TENSACH { get; set; }

        [StringLength(100)]
        public string TACGIA { get; set; }

        public int? SOTRANG { get; set; }

        [StringLength(100)]
        public string THELOAI { get; set; }

        [StringLength(100)]
        public string TINHTRANG { get; set; }

        [StringLength(100)]
        public string NHAXUATBAN { get; set; }

        [StringLength(100)]
        public string NAMXUATBAN { get; set; }
    }
}
