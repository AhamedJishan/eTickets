using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _db;
        public ActorsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var actors = _db.Actors.ToList();
            return View(actors);
        }
    }
}
