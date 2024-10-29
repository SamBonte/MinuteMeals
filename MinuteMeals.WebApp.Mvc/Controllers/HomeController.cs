using Microsoft.AspNetCore.Mvc;
using MinuteMeals.WebApp.Mvc.Database;
/*using MinuteMeals.WebApp.Mvc.Models; //Nodig bij Home pagina situatie */

namespace MinuteMeals.WebApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        /* Index actie situatie Home pagina
        // GET: Home
        public IActionResult Index()
        {
            var recipes = _context.Recipes.ToList(); // Haal alle recepten op
            return View(recipes); // Geef de recepten door aan de view
        }*/

        /* Details actie situatie Home pagina
        // GET: Home/Details/5
        public IActionResult Details(int id)
        {
            var recipe = _context.Recipes.FirstOrDefault(r => r.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }*/


        // GET: Home/Details/5
        public IActionResult Details(int id)
        {
            var recipe = _context.Recipes.FirstOrDefault(r => r.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }

        // Index action
        public IActionResult Index()
        {
            var recipes = _context.Recipes.ToList();
            return View(recipes);
        }

    }
}