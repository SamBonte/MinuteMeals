using Microsoft.AspNetCore.Mvc;
using MinuteMeals.WebApp.Mvc.Database;

namespace MinuteMeals.WebApp.Mvc.Controllers
{
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var recipes = _context.Recipes.ToList();
            return View(recipes);
        }
    }
}