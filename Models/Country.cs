using System.Collections.Generic;

namespace Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Region> Region { get; set; }
        public virtual Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}
