using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace POSProfessional.Models
{
    public partial class POSProfessionalDBContext : DbContext
    {
        public POSProfessionalDBContext()
        {
        }

        public POSProfessionalDBContext(DbContextOptions<POSProfessionalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.Catid);

                entity.ToTable("categories");

                entity.Property(e => e.Catid)
                    .HasColumnName("catid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Catdesc)
                    .HasColumnName("catdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Catname)
                    .HasColumnName("catname")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
