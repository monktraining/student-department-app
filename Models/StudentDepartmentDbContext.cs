using Microsoft.EntityFrameworkCore;

namespace StudentDepartmentApp.Models
{
    public sealed class StudentDepartmentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        public StudentDepartmentDbContext(DbContextOptions<StudentDepartmentDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}