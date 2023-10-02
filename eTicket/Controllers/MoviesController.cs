using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _db;
        public MoviesController(AppDbContext db)
        {
            _db = db;
        }
		public async Task<IActionResult> Index()
		{
			var allMovies = await _db.Movies.Include(n=>n.Cinema).OrderBy(n=>n.Name).ToListAsync();
			return View(allMovies);
		}
	}
}
