using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        // The display attribute that should specify what to display
        //The DataType attribute on ReleaseDate 
        //that makes sure that the date is displayed and not the time information. 
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }

        // A required attribute so that Entity Framework
        // can correctly locate Price to currency in the database.
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string? Rating { get; set; }

    }
}
