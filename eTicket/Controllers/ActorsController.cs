using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
			var data = _db.Actors.ToList();
			return View(data);
		}
	}
}
