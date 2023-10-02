using eTicket.Models;

namespace eTicket.Data.Services
{
	public interface IActorService
	{
		IEnumerable<Actor> GetAllActors();
		Actor GetActor(int id);
		void AddActor(Actor actor);
		void RemoveActor(int id);
		Actor UpdateActor(int id, Actor newActor);
	}
}
