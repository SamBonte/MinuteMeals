using Microsoft.EntityFrameworkCore;
using MinuteMeals.WebApp.Mvc.Models;

namespace MinuteMeals.WebApp.Mvc.Database
{
    public class ApplicationDbContext : DbContext
    {
        // Opties doorgeven aan de basis DbContext-klasse
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Definieer DbSets
        public DbSet<Recipe> Recipes { get; set; }
    }
}