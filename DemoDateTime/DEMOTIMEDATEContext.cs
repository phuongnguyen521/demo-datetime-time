using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DemoDateTime
{
    public partial class DEMOTIMEDATEContext : DbContext
    {
        public DEMOTIMEDATEContext()
        {
        }

        public DEMOTIMEDATEContext(DbContextOptions<DEMOTIMEDATEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Testdatetime> Testdatetimes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local)\\;uid=sa;pwd=123;database=DEMOTIMEDATE");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Testdatetime>(entity =>
            {
                entity.ToTable("testdatetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Note)
                    .HasMaxLength(20)
                    .HasColumnName("note");

                entity.Property(e => e.Time1)
                    .HasColumnType("datetime")
                    .HasColumnName("time1")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Time2)
                    .HasColumnType("date")
                    .HasColumnName("time2")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
