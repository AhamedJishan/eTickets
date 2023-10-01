using eTicket.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTicket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _db;
        public CinemasController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
