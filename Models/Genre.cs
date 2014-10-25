using System.Collections.Generic;

namespace Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string NameOfGenre { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
