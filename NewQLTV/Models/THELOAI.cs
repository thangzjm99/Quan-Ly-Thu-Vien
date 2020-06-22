namespace NewQLTV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THELOAI")]
    public partial class THELOAI
    {
        [Key]
        [Column("THELOAI")]
        [StringLength(100)]
        public string THELOAI1 { get; set; }

        public int? MATHELOAI { get; set; }
    }
}
