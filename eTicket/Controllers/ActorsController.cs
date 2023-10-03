using eTicket.Data;
using eTicket.Data.Services;
using eTicket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
		public async Task<IActionResult> Index()
		{
			var data = await _service.GetAllActors();
			return View(data);
		}

        // Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
		public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
		    {
            if (!ModelState.IsValid)
			{
				return View(actor);
			}
            _service.AddActor(actor);
            return RedirectToAction("Index");
		}
	}
}
