using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Models;

namespace Data_layer
{
    public class Repository
    {
        private RadioContext db;
        public Repository(RadioContext dbContext)
        {
            db = dbContext;
        }

        public MainPageVM GetMainPage()
        {
            var toReturn = new MainPageVM();
            var CountriesPossible = new List<SelectListItem>();
            foreach (var country in db.Countries)
            {
                var item = new SelectListItem
                {
                    Value = country.CountryId.ToString(),
                    Text = country.CountryName,
                    Selected = false
                };
                CountriesPossible.Add(item);
            }
            var GenresPossible = new List<SelectListItem>();
            foreach (var genre in db.Genres)
            {
                var item = new SelectListItem
                {
                    Value = genre.GenreId.ToString(),
                    Text = genre.NameOfGenre,
                    Selected = false
                };
                GenresPossible.Add(item);
            }
            toReturn.Countries = CountriesPossible;
            toReturn.Genres = GenresPossible;
            return toReturn;
        }
    }
}
