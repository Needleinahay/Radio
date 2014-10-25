using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Picture
    {
        [Key, ForeignKey("Author")]
        public int AuthorId { get; set; }

        public string PicturePath { get; set; }

        public virtual Author Author { get; set; }
    }
}
