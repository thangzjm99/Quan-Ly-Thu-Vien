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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAMUONSACH { get; set; }

        public int? MAMUONTRA { get; set; }

        public int? MATHETV { get; set; }

        public int? MASACH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYMUON { get; set; }

        public virtual DONGSACH DONGSACH { get; set; }

        public virtual THETHUVIEN THETHUVIEN { get; set; }
    }
}
