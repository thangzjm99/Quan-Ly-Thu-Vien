namespace NewQLTV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TINHTRANGSACH")]
    public partial class TINHTRANGSACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TINHTRANGSACH()
        {
            DONGSACHes = new HashSet<DONGSACH>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATINHTRANG { get; set; }

        [Column("TINHTRANGSACH")]
        [StringLength(100)]
        public string TINHTRANGSACH1 { get; set; }

        [StringLength(100)]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONGSACH> DONGSACHes { get; set; }
    }
}
