using Microsoft.EntityFrameworkCore;
using HWPlatform.DAL.Models;

namespace HWPlatform.DAL.Data;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    {

    }

    // Create tables DbSets
    public DbSet<User> Users { get; set; }
    public DbSet<UserRoles> UserRoles { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<HomeworkAssignment> HomeworkAssignments { get; set; }
    public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set; }
    public DbSet<StudentDetails> StudentDetails { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    // Set table relationships
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Create relationship between the UserRoles and Users tables
        modelBuilder
            .Entity<UserRoles>()
            .HasMany(ur => ur.Users)
            .WithOne()
            .HasForeignKey(u => u.RoleId)
            .OnDelete(DeleteBehavior.NoAction);

        // Create relationship between the Users and StudentDetails tables
        modelBuilder
            .Entity<User>()
            .HasOne(u => u.Student)
            .WithOne()
            .HasForeignKey<StudentDetails>(sd => sd.UserId)
            .IsRequired(false);

        // Create relationship between the Users and Teachers tables
        modelBuilder
            .Entity<User>()
            .HasOne(u => u.Teacher)
            .WithOne()
            .HasForeignKey<Teacher>(t => t.UserId)
            .IsRequired(false);

        // Create relationship between the StudentDetails and Classes tables
        modelBuilder
            .Entity<Class>()
            .HasMany(c => c.Students)
            .WithOne()
            .HasForeignKey(sd => new { sd.ClassId1, sd.ClassId2 })
            .OnDelete(DeleteBehavior.NoAction);

        // Create relationship between the Classes and Teachers tables
        modelBuilder
            .Entity<Class>()
            .HasMany(c => c.Teachers)
            .WithMany(t => t.Classes);

        // Create relationship between the Teachers and Subjects tables
        modelBuilder
            .Entity<Teacher>()
            .HasMany(t => t.Subjects)
            .WithOne()
            .HasForeignKey(s => s.TeacherId)
            .OnDelete(DeleteBehavior.NoAction);

        // Create relationship between the Teachers and HomeworkAssignments tables
        modelBuilder
            .Entity<Teacher>()
            .HasMany(t => t.Assignments)
            .WithOne()
            .HasForeignKey(ha => ha.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        // Create relationship between the HomeworkAssignemnts and HomeworkSubmissions tables
        modelBuilder
            .Entity<HomeworkAssignment>()
            .HasMany(ha => ha.Submissions)
            .WithOne()
            .HasForeignKey(hs => hs.AssignmentId)
            .OnDelete(DeleteBehavior.NoAction);

        // Create relationship between the HomeworkSubmissions and Grades tables
        modelBuilder
            .Entity<HomeworkSubmission>()
            .HasOne(hs => hs.Grade)
            .WithOne()
            .HasForeignKey<Grade>(g => g.SubmissionId)
            .IsRequired(false);

        // Create relationship between StudentDetails and HomeworkSubmissions tables
        modelBuilder
            .Entity<HomeworkSubmission>()
            .HasOne(hs => hs.Student)
            .WithMany()
            .HasForeignKey(hs => hs.StudentId)
            .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);
    }
}
