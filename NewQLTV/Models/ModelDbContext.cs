namespace NewQLTV.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDbContext : DbContext
    {
        public ModelDbContext()
            : base("name=ModelDbContext2")
        {
        }

        public virtual DbSet<DOCGIA> DOCGIAs { get; set; }
        public virtual DbSet<DONGSACH> DONGSACHes { get; set; }
        public virtual DbSet<MUONSACK> MUONSACKs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
        public virtual DbSet<THETHUVIEN> THETHUVIENs { get; set; }
        public virtual DbSet<TINHTRANGSACH> TINHTRANGSACHes { get; set; }
        public virtual DbSet<TRASACH> TRASACHes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DOCGIA>()
                .Property(e => e.IMAGE)
                .IsUnicode(false);

            modelBuilder.Entity<DONGSACH>()
                .Property(e => e.IMAGE)
                .IsUnicode(false);
        }
    }
}
