﻿using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class PracticeDbContext: DbContext
    {
        private IConfiguration _configuration;

        //public DbSet<User> User { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; }
        public DbSet<Campaign> Campaing { get; set; }

        public PracticeDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetSection("Database").GetSection("ConnectionString").Value;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
