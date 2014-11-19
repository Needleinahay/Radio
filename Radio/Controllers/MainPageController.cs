using System;
using System.Collections.Generic;
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


        [HttpPost]
        public ActionResult Play(MainPageVM mainPage)
        {
            var songs = Repository.GetFilteredSongs(mainPage.CountrySelected, mainPage.GenreSelected).ToArray();
            var random = new Random();
            int randomSongIndex;
            do
            {
                randomSongIndex = random.Next(0, songs.Length);
            } while (randomSongIndex == mainPage.SongPlayed);

            var songViewModel = new MainPageVM
            {
                BasicInfo = songs[randomSongIndex].Author.GeneralInfo,
                PicturePath = songs[randomSongIndex].Author.Picture.PicturePath,
                SongPath = songs[randomSongIndex].SongPath,
                Title = songs[randomSongIndex].Author.Title,
                SongName = songs[randomSongIndex].Title,
                CountrySelected = mainPage.CountrySelected,
                Link = songs[randomSongIndex].Author.LinkToSource,

                GenreSelected = mainPage.GenreSelected,
                SongPlayed = randomSongIndex,
                Rates = Repository.GetRates()
            };

            if (mainPage.RatesSelected != 0)
                Repository.SaveRateRules(mainPage.SongPlayed, mainPage.RatesSelected);

            ViewBag.Title = Radio;
            return View(songViewModel);
        }

    }
}
