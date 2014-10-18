using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string GeneralInfo { get; set; }
        public string LinkToSource { get; set; }

        [Required]
        public virtual Picture Picture { get; set; }
        public virtual ProducerInfo ProducerInfo { get; set; }
        public virtual ICollection<Song> Songs { get; set; }

        [Required]
        public Genre Genre { get; set; }
        [Required]
        public Country Country { get; set; }
        public string Region { get; set; }
    }
}
