using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        internal static ApplicationDbContext dbContext;
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public ApplicationDbContext(DbContextOptions options)
            : base(options) { }
        public ApplicationDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=192.168.1.146;Database=PopulaceDb;Uid=root;Pwd=12345678");
            }
        }

    }
}
