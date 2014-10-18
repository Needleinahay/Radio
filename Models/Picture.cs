namespace Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string PicturePath { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
