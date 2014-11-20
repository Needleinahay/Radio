using System.Collections.Generic;
using System.Web.Mvc;

namespace Models
{
    public class CreateAuthorVM
    {
        public List<SelectListItem> Genres { get; set; }

        public List<SelectListItem> Countries { get; set; }

        public Author Author { get; set; }
    }
}
