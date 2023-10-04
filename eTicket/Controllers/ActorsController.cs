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
			var data = await _service.GetAllActorsAsync();
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
            await _service.AddActorAsync(actor);
            return RedirectToAction("Index");
		}

        // Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetActorByIdAsync(id);
            if (actorDetails == null) return View("Empty");

            return View(actorDetails);
        }
	}
}   
