using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace azurecoremvc
{
    public class EmployeeContext : DbContext
    {
        public DbSet<employee> employee { get; set; }
        private readonly IConfiguration _configuration;
        public string DbPath { get; }

        public EmployeeContext(IConfiguration _config)
        {
            _configuration = _config;
            DbPath = _configuration.GetConnectionString("SQLConnection");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(DbPath);
    }

    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }

    }

}