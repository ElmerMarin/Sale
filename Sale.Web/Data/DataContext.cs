﻿using Microsoft.EntityFrameworkCore;
using Sale.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sale.Web.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options):base (options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}
