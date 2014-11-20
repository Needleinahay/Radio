using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please type your password")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please type your email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Please type the title of the band")]
        public string Title { get; set; }
        
        [Display(Name = "General info")]
        public string GeneralInfo { get; set; }

        [Display(Name = "Your Website")]
        public string LinkToSource { get; set; }

        public virtual Picture Picture { get; set; }
        public virtual ProducerInfo ProducerInfo { get; set; }
        public virtual ICollection<Song> Songs { get; set; }

        public Genre Genre { get; set; }
        [Display(Name = "Your Genre")]
        public int? GenreId { get; set; }

        public Country Country { get; set; }
        [Display(Name = "Your Country")]
        public int? CountryId { get; set; }
    }
}
