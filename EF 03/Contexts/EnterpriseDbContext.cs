using EF_03.Entities;
using Entity_Framework_01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.Contexts
{
    internal class EnterpriseDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          =>   //optionsBuilder.UseSqlServer("Data source = . ; Initial Catalog = Enterprise; Integarted Security = true") //old
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = .; Database = Enterprise; Trusted_Connection = true");



        public DbSet<Student> Student { get; set; }

        public DbSet<Course> Course { get; set; }

        public DbSet<Employee> employees { get; set; }
        //Map Class To Table => Property InSide Class Dbcontext Must be Dbset Of Entity
        // Name Of Table = Name Of Property

        public DbSet<Department> departments { get; set; }
        public DbSet<Projects> projects { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<Student>()
            // .HasMany(S => S.Course)
            // .WithMany(C => C.Student);
            //no Represenation For Many To Many Relation In Database

            modelBuilder.Entity<StudentCourse>()
                .HasKey(SC => new { SC.StudentId, SC.CourseId });
            //Composite PK

            modelBuilder.Entity<Student>()
                .HasMany(S => S.StudentCourses)
                .WithOne(SC => SC.Student)
                .IsRequired(true)
                .HasForeignKey(SC => SC.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(C => C.StudentCourses)
                .WithOne(SC => SC.Course);
                 
        }
    }
}
