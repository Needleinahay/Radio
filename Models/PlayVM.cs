using System.Collections.Generic;
using System.Web.Mvc;

namespace Models
{
    public class PlayVM
    {
        public int CountrySelected { get; set; }
        public int GenreSelected { get; set; }
        public string SongPath { get; set; }
        public int SongPlayed { get; set; }

        public string PicturePath { get; set; }
        public string Title { get; set; }
        public string SongName { get; set; }
        public string BasicInfo { get; set; }
        public string Link { get; set; }

        public List<SelectListItem> Rates { get; set; }
        public int RatesSelected { get; set; }
    }
}
