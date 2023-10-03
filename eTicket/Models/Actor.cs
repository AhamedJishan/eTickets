using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

		[Display(Name = "Full Name")]
		[Required(ErrorMessage = "Name is required")]
		public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public IEnumerable<Actor_Movie>? Actors_Movies { get; set;}

    }
}
