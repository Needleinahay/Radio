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

        /// <summary>
        /// Gets the main page.
        /// </summary>
        /// <returns></returns>
        public MainPageVM GetMainPage()
        {
            var toReturn = new MainPageVM();
            var countriesPossible = new List<SelectListItem>();
            foreach (var country in db.Countries)
            {
                var item = new SelectListItem
                {
                    Value = country.CountryId.ToString(),
                    Text = country.CountryName,
                    Selected = false
                };
                countriesPossible.Add(item);
            }
            var genresPossible = new List<SelectListItem>();
            foreach (var genre in db.Genres)
            {
                var item = new SelectListItem
                {
                    Value = genre.GenreId.ToString(),
                    Text = genre.NameOfGenre,
                    Selected = false
                };
                genresPossible.Add(item);
            }
            toReturn.Countries = countriesPossible;
            toReturn.Genres = genresPossible;
            return toReturn;
        }

        /// <summary>
        /// Gets the filtered songs.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <param name="genre">The genre.</param>
        /// <returns></returns>
        public IEnumerable<Song> GetFilteredSongs(int country, int genre)
        {
            return db.Songs.Where(x => x.Author.Country.CountryId == country && x.Author.Genre.GenreId == genre);
        }


        public List<SelectListItem> GetRates()
        {
            var ratesPossible = new List<SelectListItem>();
            ratesPossible.Add(new SelectListItem
            {
                Value = "1",
                Text = "Very bad",
                Selected = false
            });
            ratesPossible.Add(new SelectListItem
            {
                Value = "2",
                Text = "Bad",
                Selected = false
            });
            ratesPossible.Add(new SelectListItem
            {
                Value = "3",
                Text = "Ok",
                Selected = false
            });
            ratesPossible.Add(new SelectListItem
            {
                Value = "4",
                Text = "Good",
                Selected = false
            });
            ratesPossible.Add(new SelectListItem
            {
                Value = "5",
                Text = "Great",
                Selected = false
            });
            return ratesPossible;
        }

        public void SaveRateRules(int? songId, int rateRules)
        {
            if (songId != null)
            {
                var songRated = db.Songs.Find(songId);
                songRated.RateRules.RatingGivedByListener += rateRules;
                db.SaveChanges();
            }
        }
    }
}
