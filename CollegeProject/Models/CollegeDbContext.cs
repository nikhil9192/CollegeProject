using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

using Microsoft.EntityFrameworkCore;

namespace CollegeProject.Models
{
    public class CollegeDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Subject)
                .WithOne()
                .HasForeignKey<Teacher>(t => t.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
