using eTicket.Models;

namespace eTicket.Data.Services
{
	public interface IActorsService
	{
		Task<IEnumerable<Actor>> GetAllActors();
		Actor GetActor(int id);
		void AddActor(Actor actor);
		void RemoveActor(int id);
		Actor UpdateActor(int id, Actor newActor);
	}
}
