using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string GeneralInfo { get; set; }
        public string LinkToSource { get; set; }

        public virtual Picture Picture { get; set; }
        public virtual ProducerInfo ProducerInfo { get; set; }
        public virtual ICollection<Song> Songs { get; set; }

        public Genre Genre { get; set; }
        public int? GenreId { get; set; }

        public Country Country { get; set; }
        public int? CountryId { get; set; }
    }
}
