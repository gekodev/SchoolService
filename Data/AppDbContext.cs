using Microsoft.EntityFrameworkCore;
using SchoolService.Models;
namespace SchoolService.Data;

public class AppDbContext: DbContext
{

  
  public DbSet<AcademicSession> AcademicSession { get; set; }
  public DbSet<Clazz> Clazz { get; set; }
  public DbSet<Course> Course { get; set; }
  public DbSet<Demographic> Demographic { get; set; }
  public DbSet<Enrollment> Enrollment { get; set; }
  public DbSet<Org> Org{ get; set; }
  public DbSet<Relationship> Relationship { get; set; }
  public DbSet<Rol> Rol { get; set; }
  public DbSet<Room> Room { get; set; }
  public DbSet<School> School { get; set; }
  public DbSet<Section> Section { get; set; }
  public DbSet<Student> Student { get; set; }
  public DbSet<StudentEnrollment> StudentEnrollment { get; set; }
  public DbSet<Subject> Subject{ get; set; }
  public DbSet<Teacher> Teacher { get; set; }
  public DbSet<TeacherRoster> TeacherRoster { get; set; }
  public DbSet<TimeBlock> TimeBlock { get; set; }
  public DbSet<User> User { get; set; }
  public DbSet<UserFlag> UserFlag { get; set; }
  public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
  {

  }

  protected override void OnConfiguring(DbContextOptionsBuilder options)
           //=> options.UseNpgsql("Host=school.postgres.database.azure.com;Database=school;Username=mrgeko;Password=Global.2011")
           => options.UseNpgsql("Host=localhost;Username=postgres;Password=Global.2011;Database=school")
     .UseSnakeCaseNamingConvention();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
      modelBuilder.Entity<Room>().Property(b => b.SisId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<AcademicSession>().Property(b => b.SourcedId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<Clazz>().Property(b => b.SourcedId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<Course>().Property(b => b.SourcedId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<Demographic>().Property(b => b.UserSourcedId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<Org>().Property(b => b.SourcedId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<Org>().Property(b => b.SourcedId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<School>().Property(b => b.SisId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<Section>().Property(b => b.SisId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<Student>().Property(b => b.SisId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<Subject>().Property(b => b.SourcedId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<Teacher>().Property(b => b.SisId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<TimeBlock>().Property(b => b.SisId).HasIdentityOptions(startValue: 100);
      modelBuilder.Entity<User>().Property(b => b.SourcedId).HasIdentityOptions(startValue: 100);

  }


}




