using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class RateRules
    {
        public int RatingGivedByListener { get; set; }
        public int PeopleListenedToAnd { get; set; }
        public int PeopleListenedHalfWay { get; set; }

        [Key, ForeignKey("Song")]
        public int SongId { get; set; }
        public virtual Song Song { get; set; }
    }
}
