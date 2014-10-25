using System.Collections.Generic;

namespace Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}
