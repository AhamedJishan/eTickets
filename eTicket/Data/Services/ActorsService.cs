using eTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace eTicket.Data.Services
{
	public class ActorsService : IActorsService
	{

		private readonly AppDbContext _db;
		public ActorsService(AppDbContext db)
		{
			_db = db;
		}

		public async Task AddActorAsync(Actor actor)
		{
			await _db.Actors.AddAsync(actor);
			await _db.SaveChangesAsync();
		}

		public async Task<Actor> GetActorByIdAsync(int id)
		{
			var result = await _db.Actors.FirstOrDefaultAsync(a => a.Id == id);
			return result;
		}

		public async Task<IEnumerable<Actor>> GetAllActorsAsync()
		{
			var result = await _db.Actors.ToListAsync();
			return result;
		}

		public void RemoveActor(int id)
		{
			throw new NotImplementedException();
		}

		public Actor UpdateActor(int id, Actor newActor)
		{
			throw new NotImplementedException();
		}
	}
}
