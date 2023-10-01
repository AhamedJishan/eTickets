using eTicket.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTicket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _db;
        public ProducersController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
