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
        [StringLength(100)]
        public string MATHELOAI { get; set; }

        public int? TENTHELOAI { get; set; }
    }
}
