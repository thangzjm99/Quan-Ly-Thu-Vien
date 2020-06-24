namespace NewQLTV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THETHUVIEN")]
    public partial class THETHUVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THETHUVIEN()
        {
            DOCGIAs = new HashSet<DOCGIA>();
            MUONSACKs = new HashSet<MUONSACK>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATHETV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYBATDAU { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYKETTHUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCGIA> DOCGIAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUONSACK> MUONSACKs { get; set; }
    }
}
