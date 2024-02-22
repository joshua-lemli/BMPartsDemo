using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BMParts.Data
{
    internal class PartsDbContext(string filePath) : DbContext
    {
        private readonly string filePath = filePath;

        public DbSet<Part> Parts => Set<Part>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={filePath}");
    }
}
