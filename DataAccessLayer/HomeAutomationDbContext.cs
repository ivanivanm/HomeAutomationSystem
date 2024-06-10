using Microsoft.EntityFrameworkCore;
using System;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.BuilderModels;
using DataAccessLayer.MainModel;

namespace DataAccessLayer
{
    public class HomeAutomationDbContext: DbContext
    {
        public HomeAutomationDbContext(DbContextOptions<HomeAutomationDbContext> options) : base(options)
        {

        }
        public HomeAutomationDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(r =>
            {
                r.HasMany(b => b.TVs).WithOne(t => t.Room).OnDelete(DeleteBehavior.Cascade);
                r.HasMany(b => b.Lamps).WithOne(t => t.Room).OnDelete(DeleteBehavior.Cascade);
                r.HasMany(b => b.Fridges).WithOne(t => t.Room).OnDelete(DeleteBehavior.Cascade);
                r.HasMany(b => b.AirConditioners).WithOne(t => t.Room).OnDelete(DeleteBehavior.Cascade);

                r.HasKey(b => b.Id);
            });

            modelBuilder.Entity<AirConditioner>(a =>
            {
                a.HasKey(c => c.Id);
            });
            modelBuilder.Entity<Fridge>(f =>
            {
                f.HasKey(c => c.Id);
            });
            modelBuilder.Entity<Lamp>(l =>
            {
                l.HasKey(c => c.Id);
            });
            modelBuilder.Entity<TV>(tv =>
            {
                tv.HasKey(c => c.Id);
            });
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-SMAPSCS\\SQLEXPRESS; Database = HomeAutomationControllerDb; Trusted_Connection = True;TrustServerCertificate=True");
            }
            optionsBuilder.UseLazyLoadingProxies(true);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<AirConditioner> Conditioners { get; set; }
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<Lamp> Lamps { get; set; }
        public DbSet<TV> TVs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Home> Home { get; set; }
    }
}
