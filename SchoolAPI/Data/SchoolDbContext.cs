using Microsoft.EntityFrameworkCore;
using SchoolLib;

namespace SchoolAPI;

public class SchoolDbContext : DbContext {
  public DbSet<Student> Students { get; set; }

  public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    builder.Entity<Student>().HasData(
      new {
        StudentId = 1,
        FirstName = "Tom",
        LastName = "Day",
        School = "Physics"
      }, new {
        StudentId = 2,
        FirstName = "Ann",
        LastName = "Fox",
        School = "Geology"
      }, new {
        StudentId = 3,
        FirstName = "Art",
        LastName = "Ash",
        School = "Nursing"
      }, new {
        StudentId = 4,
        FirstName = "Mia",
        LastName = "Hay",
        School = "Science"
      }
    );
  }
}

