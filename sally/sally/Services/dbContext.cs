using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace sally.Services
{
     public class databaseContext : DbContext
     {
        public databaseContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqlitePath = Path.Combine(System.Environment.GetFolderPath(Device.RuntimePlatform == Device.Android? System.Environment.SpecialFolder.Personal : System.Environment.SpecialFolder.LocalApplicationData), @"MetaData");
            if (!Directory.Exists(sqlitePath))
                Directory.CreateDirectory(sqlitePath);
            var fullPathSqlite = Path.Combine(sqlitePath,"sally");
            optionsBuilder.UseSqlite($"Filename={fullPathSqlite}");
        }
        public DbSet<models.patient> patient { get; set; }

    }
}
