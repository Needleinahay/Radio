using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Models
{
    public class CreateAuthorVM
    {
        public List<SelectListItem> Genres { get; set; }

        public List<SelectListItem> Countries { get; set; }

        [Required(ErrorMessage = "Please type password")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please type email")]
        public string Email { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string GeneralInfo { get; set; }
        public string Link { get; set; }

        public int Genre { get; set; }
        public int Country { get; set; }
    }
}
