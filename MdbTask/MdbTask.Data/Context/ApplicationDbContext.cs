using MdbTask.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MdbTask.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Media> Media { get; set; }

        public DbSet<Cast> Cast { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public string DbPath { get; private set; }

        public ApplicationDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}mdbtask.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
