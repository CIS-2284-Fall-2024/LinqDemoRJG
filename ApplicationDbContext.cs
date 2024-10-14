using LinqDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace LinqDemo
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ToDoDB;Trusted_Connection=True");
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
