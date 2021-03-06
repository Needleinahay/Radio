﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Models
{
    public class MainPageVM
    {
        public List<SelectListItem> Genres { get; set; }

        [Display(Name = "Countries of authors")]
        public List<SelectListItem> Countries { get; set; }


        [Required(ErrorMessage = "Please choose the genre")]
        public int GenreSelected { get; set; }

        [Required(ErrorMessage = "Please choose the country")]
        public int CountrySelected { get; set; }

        public int? SongPlayed { get; set; }
        public string SongPath { get; set; }

        public string PicturePath { get; set; }
        public string Title { get; set; }
        public string SongName { get; set; }
        public string BasicInfo { get; set; }
        public string Link { get; set; }

        public List<SelectListItem> Rates { get; set; }
        public int RatesSelected { get; set; }
    }
}
