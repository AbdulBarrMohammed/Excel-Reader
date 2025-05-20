using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExcelReader.Model;
using Microsoft.EntityFrameworkCore;

namespace ExcelReader.Data
{
    public class LegoDBContext : DbContext
    {
        public DbSet<LegoSet> Legos { get; set; }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ExcelReader;User Id=SA;Password=Allahis#1;TrustServerCertificate=True;");
    }
}
