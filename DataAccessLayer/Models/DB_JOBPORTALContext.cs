using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JSEProject.Models
{
    public partial class DB_JOBPORTALContext : DbContext
    {
        public DB_JOBPORTALContext()
        {
        }

        public DB_JOBPORTALContext(DbContextOptions<DB_JOBPORTALContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCandidCompaniesList> TblCandidCompaniesList { get; set; }
        public virtual DbSet<TblRegisterUser> TblRegisterUser { get; set; }
        public virtual DbSet<TblRoles> TblRoles { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }
        public virtual DbSet<TblUserEducationDetails> TblUserEducationDetails { get; set; }
        public virtual DbSet<TblUserLogin> TblUserLogin { get; set; }
        public virtual DbSet<TblUserLoginCheckList> TblUserLoginCheckList { get; set; }
        public virtual DbSet<TblUsrDocs> TblUsrDocs { get; set; }
        public virtual DbSet<TbluserExitForm> TbluserExitForm { get; set; }
        public virtual DbSet<TbluserRoles> TbluserRoles { get; set; }
        public virtual DbSet<TbluserWorkingStatus> TbluserWorkingStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=2PG3XS2;Database=DB_JOBPORTAL;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCandidCompaniesList>(entity =>
            {
                entity.ToTable("tblCandidCompaniesList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("companyName")
                    .HasMaxLength(50);

                entity.Property(e => e.CurrentCompany).HasColumnName("currentCompany");

                entity.Property(e => e.FromDate)
                    .HasColumnName("fromDate")
                    .HasColumnType("date");

                entity.Property(e => e.ToDate)
                    .HasColumnName("toDate")
                    .HasColumnType("date");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblRegisterUser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__tblRegis__CBA1B2579B6BC610");

                entity.ToTable("tblRegisterUser");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("contact_Number")
                    .HasMaxLength(15);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(50);

                entity.Property(e => e.ForeighnerIdNumber)
                    .HasColumnName("foreighner_id_number")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(50);

                entity.Property(e => e.MaidenName)
                    .HasColumnName("maiden_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.MaritialStatus)
                    .IsRequired()
                    .HasColumnName("maritial_status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middleName")
                    .HasMaxLength(50);

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasColumnName("nationality")
                    .HasMaxLength(50);

                entity.Property(e => e.Passport)
                    .HasColumnName("passport")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.TurkishIdNumber)
                    .HasColumnName("turkish_id_number")
                    .HasMaxLength(50);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblRoles>(entity =>
            {
                entity.ToTable("tblRoles");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUser__CB9A1CDF1294C761");

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUserEducationDetails>(entity =>
            {
                entity.ToTable("tblUserEducationDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.Course)
                    .HasColumnName("course")
                    .HasMaxLength(50);

                entity.Property(e => e.CourseTitle)
                    .HasColumnName("courseTitle")
                    .HasMaxLength(50);

                entity.Property(e => e.UniversityAddress)
                    .HasColumnName("universityAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.Universityname)
                    .IsRequired()
                    .HasColumnName("universityname")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userID")
                    .HasMaxLength(50);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUserLogin>(entity =>
            {
                entity.ToTable("tblUserLogin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LogInDtTime)
                    .HasColumnName("logIn_DtTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUserLoginCheckList>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUserL__CB9A1CDF75B93C69");

                entity.ToTable("tblUserLoginCheckList");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MandatoryQuestion1)
                    .HasColumnName("mandatoryQuestion1")
                    .HasMaxLength(50);

                entity.Property(e => e.MandatoryQuestion2)
                    .HasColumnName("mandatoryQuestion2")
                    .HasMaxLength(50);

                entity.Property(e => e.MandatoryQuestion3)
                    .HasColumnName("mandatoryQuestion3")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUsrDocs>(entity =>
            {
                entity.ToTable("tblUsrDocs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocType)
                    .HasColumnName("docType")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FilePath)
                    .HasColumnName("filePath")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userId")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbluserExitForm>(entity =>
            {
                entity.ToTable("tbluserExitForm");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExitDateTime)
                    .HasColumnName("exitDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExitDeleteTimestamp)
                    .HasColumnName("exit_delete_timestamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExitDeleteUpdatedby)
                    .HasColumnName("exit_delete_updatedby")
                    .HasMaxLength(50);

                entity.Property(e => e.ExitFaq1)
                    .HasColumnName("exit_faq1")
                    .HasMaxLength(50);

                entity.Property(e => e.ExitFaq2)
                    .HasColumnName("exit_faq2")
                    .HasMaxLength(50);

                entity.Property(e => e.ExitFaq3)
                    .HasColumnName("exit_faq3")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbluserRoles>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbluserR__1788CCACF78C0F61");

                entity.ToTable("tbluserRoles");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<TbluserWorkingStatus>(entity =>
            {
                entity.ToTable("tbluserWorkingStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkingStatus).HasColumnName("workingStatus");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
