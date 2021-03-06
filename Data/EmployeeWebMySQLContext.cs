﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeWebMySQL.Models;

namespace EmployeeWebMySQL.Data
{
    public class EmployeeWebMySQLContext : DbContext
    {
        public EmployeeWebMySQLContext (DbContextOptions<EmployeeWebMySQLContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Employee> ().ToTable ( "Employee" );
        }
    }
}
