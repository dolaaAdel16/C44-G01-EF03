﻿using EF03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF03.Contexts
{
    internal class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = . ; Database = DBG04 ; Trusted_Connection = True ; TrustServerCertificate = True ");
        }

        public DbSet<Employee> Employees { get; set; }  

        public DbSet<Department> Departments { get; set; }
    }
}
