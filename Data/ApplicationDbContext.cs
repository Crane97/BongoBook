using BongoBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BongoBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } //This parameter will be the table name and will create the table with the attributes of Category
    }
}
