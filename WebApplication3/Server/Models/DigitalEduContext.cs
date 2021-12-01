using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication3.Server.Models
{
    public partial class DigitalEduContext : DbContext
    {
        public DigitalEduContext()
        {
        }

        public DigitalEduContext(DbContextOptions<DigitalEduContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Name=DigitalEdu");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answers>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("Answers_pkey");

                entity.Property(e => e.IdUser).ValueGeneratedNever();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.IdQuestionNavigation)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.IdQuestion)
                    .HasConstraintName("IdQuestion_Fk");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.Answers)
                    .HasForeignKey<Answers>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IdUser_Fk");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.IdSubjectNavigation)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.IdSubject)
                    .HasConstraintName("IdSubject_Fk");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("IdUser_Fk");
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
