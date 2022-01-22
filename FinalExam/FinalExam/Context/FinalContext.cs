using FinalExam.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Context
{
    public class FinalContext:DbContext
    {
        IConfiguration configuration;
        public FinalContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Bed> Bed { set; get; }
        public DbSet<Room> Room { set; get; }
        public DbSet<city> city { set; get; }
        public DbSet<country> country { set; get; }
        public DbSet<Department> Department { set; get; }
        public DbSet<Doctor> Doctor { set; get; }
        public DbSet<Pateint> Pateint { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("exam"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
