using System.Data.Entity;

namespace SinavOgrenciSistemi.Models
{
    public partial class dbSinavOgrenciEntities : DbContext
    {
        public dbSinavOgrenciEntities()
            : base("name=dbSinavOgrenciEntities")
        {
        }

        public virtual DbSet<TBLDERSLER> TBLDERSLER { get; set; }
        public virtual DbSet<TBLKULUPLER> TBLKULUPLER { get; set; }
        public virtual DbSet<TBLNOTLAR> TBLNOTLAR { get; set; }
        public virtual DbSet<TBLOGRENCI> TBLOGRENCI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBLDERSLER>()
                .HasMany(e => e.TBLNOTLAR)
                .WithRequired(e => e.TBLDERSLER)
                .HasForeignKey(e => e.DERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBLKULUPLER>()
                .HasMany(e => e.TBLOGRENCI)
                .WithOptional(e => e.TBLKULUPLER)
                .HasForeignKey(e => e.KulupID);

            modelBuilder.Entity<TBLOGRENCI>()
                .HasMany(e => e.TBLNOTLAR)
                .WithRequired(e => e.TBLOGRENCI)
                .HasForeignKey(e => e.OGRENCI)
                .WillCascadeOnDelete(false);
        }
    }
}

