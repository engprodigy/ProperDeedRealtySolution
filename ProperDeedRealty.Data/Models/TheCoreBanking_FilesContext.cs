using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProperDeedRealty.Data.Models
{
    public partial class TheCoreBanking_FilesContext : DbContext
    {
        public virtual DbSet<TblLodgementWithdrawal> TblLodgementWithdrawal { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-5VJ567N\\FINTRAKSQL;Database=TheCoreBanking.Files;user id=sa;password=sqluser10$;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblLodgementWithdrawal>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.FileData).HasColumnType("image");

                entity.Property(e => e.Mime)
                    .HasColumnName("MIME")
                    .HasMaxLength(50);
            });
        }
    }
}
