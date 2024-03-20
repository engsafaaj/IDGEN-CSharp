﻿using IDGEN.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGEN.Data.EF
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqlcon = @"Server=.\SQLEXPRESS;Database=IDGENDataBase;Encrypt=false;Trusted_Connection=True;"; // For Test

            optionsBuilder.UseSqlServer(sqlcon);
        }

        // Tables
        public DbSet<Colleges> Colleges { get; set; }
        public DbSet<CollegeDep> CollegeDep { get; set; }
        public DbSet<Logs> Logs { get; set; }
    }
}