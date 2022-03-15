using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class PersonnelRecordsContext : DbContext
    {
        public PersonnelRecordsContext()
        {
        }

        public PersonnelRecordsContext(DbContextOptions<PersonnelRecordsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<ImpactType> ImpactTypes { get; set; }
        public virtual DbSet<Passport> Passports { get; set; }
        public virtual DbSet<Staffing> Staffings { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Integrated Security= True; Server=LAPTOP-VJ8HF1QJ\\SQLEXPRESS; Initial Catalog=PersonnelRecords;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Archive>(entity =>
            {
                entity.ToTable("Archive");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StaffingId).HasColumnName("staffingID");

                entity.Property(e => e.TypeOfImpactId).HasColumnName("typeOfImpactID");

                entity.HasOne(d => d.Staffing)
                    .WithMany(p => p.Archives)
                    .HasForeignKey(d => d.StaffingId)
                    .HasConstraintName("FK_Archive_Staffing");

                entity.HasOne(d => d.TypeOfImpact)
                    .WithMany(p => p.Archives)
                    .HasForeignKey(d => d.TypeOfImpactId)
                    .HasConstraintName("FK_Archive_ImpactTypes");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("Education");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EducationalPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("educationalPlace");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("expirationDate");

                entity.Property(e => e.ReceiptDate)
                    .HasColumnType("date")
                    .HasColumnName("receiptDate");

                entity.Property(e => e.Speciality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("speciality");
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.ToTable("Experience");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("companyID");

                entity.Property(e => e.DepartureDate)
                    .HasColumnType("date")
                    .HasColumnName("departureDate");

                entity.Property(e => e.StaffingId).HasColumnName("staffingID");

                entity.Property(e => e.WorkerId).HasColumnName("workerID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_experience_Company");

                entity.HasOne(d => d.Staffing)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.StaffingId)
                    .HasConstraintName("FK_experience_Staffing");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.WorkerId)
                    .HasConstraintName("FK_Experience_Worker");
            });

            modelBuilder.Entity<ImpactType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Passport>(entity =>
            {
                entity.ToTable("Passport");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DivisionСode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("divisionСode");

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("issuedBy");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Registration)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("registration");

                entity.Property(e => e.Series).HasColumnName("series");

                entity.Property(e => e.Sex)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.ВateOfIssue)
                    .HasColumnType("date")
                    .HasColumnName("вateOfIssue");
            });

            modelBuilder.Entity<Staffing>(entity =>
            {
                entity.ToTable("Staffing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("companyID");

                entity.Property(e => e.EnrollmentDate)
                    .HasColumnType("date")
                    .HasColumnName("enrollmentDate");

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");

                entity.Property(e => e.WorkerId).HasColumnName("workerID");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Staffings)
                    .HasForeignKey(d => d.WorkerId)
                    .HasConstraintName("FK_Staffing_Worker");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("Worker");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EducationId).HasColumnName("educationID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PassportId).HasColumnName("passportID");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("patronymic");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("surname");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.EducationId)
                    .HasConstraintName("FK_Worker_Education");

                entity.HasOne(d => d.Passport)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.PassportId)
                    .HasConstraintName("FK_Worker_Passport");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
