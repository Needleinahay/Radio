using System;
using System.Linq;
using System.Web.Mvc;
using Data_layer;
using Models;

namespace Radio.Controllers
{
    public class MainPageController : Controller
    {
        #region Consts

        private const string Radio = "My Radio";

        #endregion

        #region Fields

        private readonly Repository _repository;

        #endregion

        #region Properties

        private Repository Repository
        {
            get { return _repository; }
        }

        #endregion

        #region Ctor

        public MainPageController()
        {
            _repository = new Repository(new RadioContext());
        }

        #endregion

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = Radio;
            return View(Repository.GetMainPage());
        }

        /// <summary>
        /// Indexes the specified parameters.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(MainPageVM parameters)
        {
            return RedirectToAction(PlaySong(parameters.CountrySelected, parameters.GenreSelected, null).ToString());
        }

        /// <summary>
        /// Plays the song.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <param name="genre">The genre.</param>
        /// <param name="songPlayed">The song played.</param>
        /// <returns></returns>
        public ActionResult PlaySong(int country, int genre, int? songPlayed)
        {
            var songs = Repository.GetFilteredSongs(country, genre).ToArray();
            int randomSongIndex;
            do
            {
                var random = new Random();
                randomSongIndex = random.Next(0, songs.Length - 1);
            } while (randomSongIndex == songPlayed);

            ViewBag.Title = Radio;
            return View(songs[randomSongIndex]);
        }

    }
}
