using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC11.EFCore
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<StudentPredmet> StudentPredmet { get; set; }
        public DbSet<Assessment> Assessment { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\source\repos\PC11\Database1.mdf");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentPredmet>().HasKey(e => new { e.StudentId, e.AbbrvId });
            modelBuilder.Entity<Assessment>().HasKey(e => new { e.StudentId, e.AbbrvId });
        }

    }
}
