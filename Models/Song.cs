namespace Models
{
    public class Song
    {
        public int AuthorId { get; set; }

        public int SongId { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public string SongPath { get; set; }

        public virtual Author Author { get; set; }
    }
}
