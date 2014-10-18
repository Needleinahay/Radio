namespace Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string NameOfGenre { get; set; }

        public virtual Author Author { get; set; }
    }
}
