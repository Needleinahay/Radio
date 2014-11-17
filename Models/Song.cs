using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public string SongPath { get; set; }
        public virtual RateRules RateRules { get; set; }

        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
