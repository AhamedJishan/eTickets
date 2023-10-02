using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _db;
        public CinemasController(AppDbContext db)
        {
            _db = db;
        }
		public async Task<IActionResult> Index()
		{
			var allCinemas = await _db.Cinemas.ToListAsync();
			return View(allCinemas);
		}
	}
}
