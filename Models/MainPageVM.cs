using System.Collections.Generic;
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
    }
}
