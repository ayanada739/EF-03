﻿using Microsoft.EntityFrameworkCore;
using Part_02_Inheritance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_02_Inheritance.DbContexts
{
    internal class CompanyDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          =>    
            optionsBuilder.UseSqlServer("Server = .; Database = Enterprise; Trusted_Connection = true");

        public DbSet<Employee> Employees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FluentAPIS
            //TBH
            modelBuilder.Entity<FullTimeEmployee>()
                .HasBaseType<Employee>();

            modelBuilder.Entity<PartTimeEmployee>()
                .HasBaseType<Employee>();

            //TPH=> Map Fulltime & Parttime Employee To One Table Employee
            //Add New Column Nvarchar Namer Disciminator [Fulltime | Parttime]

            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<FullTimeEmployee>()
            //    .HasNoKey();

            //modelBuilder.Entity<PartTimeEmployee>()
             //   .HasNoKey();


        }


        }
    }
