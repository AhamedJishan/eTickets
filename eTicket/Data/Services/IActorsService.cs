using eTicket.Models;

namespace eTicket.Data.Services
{
	public interface IActorsService
	{
		public Task<IEnumerable<Actor>> GetAllActorsAsync();
		public Task<Actor> GetActorByIdAsync(int id);
		public Task AddActorAsync(Actor actor);
		public void RemoveActor(int id);
		public Actor UpdateActor(int id, Actor newActor);
	}
}
