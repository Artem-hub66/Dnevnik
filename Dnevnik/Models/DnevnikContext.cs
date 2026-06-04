using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dnevnik.Models;

public partial class DnevnikContext : DbContext
{
    public DnevnikContext()
    {
    }

    public DnevnikContext(DbContextOptions<DnevnikContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcademicYear> AcademicYears { get; set; }

    public virtual DbSet<AnnualGrade> AnnualGrades { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Homework> Homeworks { get; set; }

    public virtual DbSet<Quarter> Quarters { get; set; }

    public virtual DbSet<QuarterlyGrade> QuarterlyGrades { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeacherSubjectClass> TeacherSubjectClasses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Dnevnik;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcademicYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("academic_years_pkey");

            entity.ToTable("academic_years");

            entity.HasIndex(e => e.YearName, "academic_years_year_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.IsCurrent)
                .HasDefaultValue(false)
                .HasColumnName("is_current");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.YearName)
                .HasMaxLength(20)
                .HasColumnName("year_name");
        });

        modelBuilder.Entity<AnnualGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("annual_grades_pkey");

            entity.ToTable("annual_grades");

            entity.HasIndex(e => new { e.StudentId, e.TeacherSubjectClassId, e.AcademicYearId }, "annual_grades_student_id_teacher_subject_class_id_academic__key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcademicYearId).HasColumnName("academic_year_id");
            entity.Property(e => e.CalculatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("calculated_at");
            entity.Property(e => e.GradeValue).HasColumnName("grade_value");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.TeacherSubjectClassId).HasColumnName("teacher_subject_class_id");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.AnnualGrades)
                .HasForeignKey(d => d.AcademicYearId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("annual_grades_academic_year_id_fkey");

            entity.HasOne(d => d.Student).WithMany(p => p.AnnualGrades)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("annual_grades_student_id_fkey");

            entity.HasOne(d => d.TeacherSubjectClass).WithMany(p => p.AnnualGrades)
                .HasForeignKey(d => d.TeacherSubjectClassId)
                .HasConstraintName("annual_grades_teacher_subject_class_id_fkey");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("classes_pkey");

            entity.ToTable("classes");

            entity.HasIndex(e => e.ClassName, "classes_class_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcademicYearId).HasColumnName("academic_year_id");
            entity.Property(e => e.ClassName)
                .HasMaxLength(20)
                .HasColumnName("class_name");
            entity.Property(e => e.ClassTeacherId).HasColumnName("class_teacher_id");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.Classes)
                .HasForeignKey(d => d.AcademicYearId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("classes_academic_year_id_fkey");

            entity.HasOne(d => d.ClassTeacher).WithMany(p => p.Classes)
                .HasForeignKey(d => d.ClassTeacherId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("classes_class_teacher_id_fkey");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("grades_pkey");

            entity.ToTable("grades");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.GradeValue).HasColumnName("grade_value");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.StudentId).HasColumnName("student_id");

            entity.HasOne(d => d.Schedule).WithMany(p => p.Grades)
                .HasForeignKey(d => d.ScheduleId)
                .HasConstraintName("grades_schedule_id_fkey");

            entity.HasOne(d => d.Student).WithMany(p => p.Grades)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("grades_student_id_fkey");
        });

        modelBuilder.Entity<Homework>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("homework_pkey");

            entity.ToTable("homework");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DueDate).HasColumnName("due_date");
            entity.Property(e => e.TeacherSubjectClassId).HasColumnName("teacher_subject_class_id");

            entity.HasOne(d => d.Class).WithMany(p => p.Homeworks)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("homework_class_id_fkey");

            entity.HasOne(d => d.TeacherSubjectClass).WithMany(p => p.Homeworks)
                .HasForeignKey(d => d.TeacherSubjectClassId)
                .HasConstraintName("homework_teacher_subject_class_id_fkey");
        });

        modelBuilder.Entity<Quarter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("quarters_pkey");

            entity.ToTable("quarters");

            entity.HasIndex(e => new { e.AcademicYearId, e.QuarterNumber }, "quarters_academic_year_id_quarter_number_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcademicYearId).HasColumnName("academic_year_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.QuarterNumber).HasColumnName("quarter_number");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.Quarters)
                .HasForeignKey(d => d.AcademicYearId)
                .HasConstraintName("quarters_academic_year_id_fkey");
        });

        modelBuilder.Entity<QuarterlyGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("quarterly_grades_pkey");

            entity.ToTable("quarterly_grades");

            entity.HasIndex(e => new { e.StudentId, e.TeacherSubjectClassId, e.QuarterId }, "quarterly_grades_student_id_teacher_subject_class_id_quarte_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CalculatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("calculated_at");
            entity.Property(e => e.GradeValue).HasColumnName("grade_value");
            entity.Property(e => e.QuarterId).HasColumnName("quarter_id");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.TeacherSubjectClassId).HasColumnName("teacher_subject_class_id");

            entity.HasOne(d => d.Quarter).WithMany(p => p.QuarterlyGrades)
                .HasForeignKey(d => d.QuarterId)
                .HasConstraintName("quarterly_grades_quarter_id_fkey");

            entity.HasOne(d => d.Student).WithMany(p => p.QuarterlyGrades)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("quarterly_grades_student_id_fkey");

            entity.HasOne(d => d.TeacherSubjectClass).WithMany(p => p.QuarterlyGrades)
                .HasForeignKey(d => d.TeacherSubjectClassId)
                .HasConstraintName("quarterly_grades_teacher_subject_class_id_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.HasIndex(e => e.Name, "roles_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("schedule_pkey");

            entity.ToTable("schedule");

            entity.HasIndex(e => new { e.TeacherSubjectClassId, e.ClassId, e.LessonDate }, "schedule_teacher_subject_class_id_class_id_lesson_date_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.Classroom)
                .HasMaxLength(50)
                .HasColumnName("classroom");
            entity.Property(e => e.LessonDate).HasColumnName("lesson_date");
            entity.Property(e => e.LessonTopic)
                .HasMaxLength(500)
                .HasColumnName("lesson_topic");
            entity.Property(e => e.QuarterId).HasColumnName("quarter_id");
            entity.Property(e => e.TeacherSubjectClassId).HasColumnName("teacher_subject_class_id");

            entity.HasOne(d => d.Class).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("schedule_class_id_fkey");

            entity.HasOne(d => d.Quarter).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.QuarterId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("schedule_quarter_id_fkey");

            entity.HasOne(d => d.TeacherSubjectClass).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.TeacherSubjectClassId)
                .HasConstraintName("schedule_teacher_subject_class_id_fkey");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("students_pkey");

            entity.ToTable("students");

            entity.HasIndex(e => e.UserId, "students_user_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.EnrollmentDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnName("enrollment_date");
            entity.Property(e => e.ParentFullName)
                .HasMaxLength(200)
                .HasColumnName("parent_full_name");
            entity.Property(e => e.ParentPhone)
                .HasMaxLength(20)
                .HasColumnName("parent_phone");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Class).WithMany(p => p.Students)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("students_class_id_fkey");

            entity.HasOne(d => d.User).WithOne(p => p.Student)
                .HasForeignKey<Student>(d => d.UserId)
                .HasConstraintName("students_user_id_fkey");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("subjects_pkey");

            entity.ToTable("subjects");

            entity.HasIndex(e => e.SubjectName, "subjects_subject_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ShortName)
                .HasMaxLength(50)
                .HasColumnName("short_name");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(150)
                .HasColumnName("subject_name");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teachers_pkey");

            entity.ToTable("teachers");

            entity.HasIndex(e => e.UserId, "teachers_user_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HireDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnName("hire_date");
            entity.Property(e => e.Qualification)
                .HasMaxLength(200)
                .HasColumnName("qualification");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithOne(p => p.Teacher)
                .HasForeignKey<Teacher>(d => d.UserId)
                .HasConstraintName("teachers_user_id_fkey");
        });

        modelBuilder.Entity<TeacherSubjectClass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teacher_subject_class_pkey");

            entity.ToTable("teacher_subject_class");

            entity.HasIndex(e => new { e.TeacherId, e.SubjectId, e.ClassId, e.AcademicYearId }, "teacher_subject_class_teacher_id_subject_id_class_id_academ_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcademicYearId).HasColumnName("academic_year_id");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.HoursPerWeek)
                .HasDefaultValue(2)
                .HasColumnName("hours_per_week");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.TeacherSubjectClasses)
                .HasForeignKey(d => d.AcademicYearId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("teacher_subject_class_academic_year_id_fkey");

            entity.HasOne(d => d.Class).WithMany(p => p.TeacherSubjectClasses)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("teacher_subject_class_class_id_fkey");

            entity.HasOne(d => d.Subject).WithMany(p => p.TeacherSubjectClasses)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("teacher_subject_class_subject_id_fkey");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TeacherSubjectClasses)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("teacher_subject_class_teacher_id_fkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Login, "users_login_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(200)
                .HasColumnName("full_name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LastLogin)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_login");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .HasColumnName("login");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasColumnName("password_hash");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("users_role_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
