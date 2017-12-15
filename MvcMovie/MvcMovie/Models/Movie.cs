using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        
        [StringLength(60, MinimumLength = 3)] // Validation Rules 
        public string Title { get; set; }
        
        [Display(Name = "Release Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", 
            ErrorMessage = "Genre must begin with a capital letter and consist of only letters or spaces")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", 
            ErrorMessage = "The field Rating must be a string with a maximum length of 5")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

    // DbContext base class provided by the Entity Framework
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}