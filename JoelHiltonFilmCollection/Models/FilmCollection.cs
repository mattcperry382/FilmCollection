using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHiltonFilmCollection.Models
{
    public class FilmCollection
    {
        [Key]
        [Required]
        public int FilmId { get; set; }
        
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [Range(0,25)]
        public string Notes { get; set; }
        // Category Table
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please select a Category.")]
        public Category Category { get; set; }
    }
}
