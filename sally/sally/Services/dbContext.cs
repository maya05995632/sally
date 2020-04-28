using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace sally.Services
{
     public class databaceContext : dbContext
    {
        Database.EnsureCreated();
        }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var sqlitePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), @"MetaData");
        if (!Directory.Exists(sqlitePath))
            Directory.CreateDirectory(sqlitePath);
        var fullPathSqlite = $"{sqlitePath}/sally";
        optionsBuilder.UseSqlite($"Filename={fullPathSqlite}");
    }
    public DbSet<Models.patient> patient { get; set; }

}
}
