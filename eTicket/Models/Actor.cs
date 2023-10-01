using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; }

		[Display(Name = "Full Name")]
		public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public IEnumerable<Actor_Movie> Actors_Movies { get; set;}

    }
}
