using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
	public class ActorsService : IActorsService
	{

		private readonly AppDbContext _db;
		public ActorsService(AppDbContext db)
		{
			_db = db;
		}

		void IActorsService.AddActor(Actor actor)
		{
			throw new NotImplementedException();
		}

		Actor IActorsService.GetActor(int id)
		{
			throw new NotImplementedException();
		}

		async Task<IEnumerable<Actor>> IActorsService.GetAllActors()
		{
			var result = await _db.Actors.ToListAsync();
			return result;
		}

		void IActorsService.RemoveActor(int id)
		{
			throw new NotImplementedException();
		}

		Actor IActorsService.UpdateActor(int id, Actor newActor)
		{
			throw new NotImplementedException();
		}
	}
}
