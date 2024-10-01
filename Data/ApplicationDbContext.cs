using Microsoft.EntityFrameworkCore;
using ShelfShare.Models;

namespace ShelfShare.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // public DbSet<Category> Categories { get; set; }
    }
}