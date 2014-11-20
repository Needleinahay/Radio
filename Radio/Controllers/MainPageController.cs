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
            var sogsIds = songs.Select(x => x.SongId).ToArray();
            var random = new Random();
            int randomSongId;
            do
            {
                var randomSongIndex = random.Next(0, sogsIds.Length);
                randomSongId = sogsIds[randomSongIndex];

            } while (randomSongId == mainPage.SongPlayed);

            var songChosen = songs.FirstOrDefault(x => x.SongId == randomSongId);

            var songViewModel = new MainPageVM
            {
                BasicInfo = songChosen.Author.GeneralInfo,
                PicturePath = songChosen.Author.Picture.PicturePath,
                SongPath = songChosen.SongPath,
                Title = songChosen.Author.Title,
                SongName = songChosen.Title,
                CountrySelected = mainPage.CountrySelected,
                Link = songChosen.Author.LinkToSource,

                GenreSelected = mainPage.GenreSelected,
                SongPlayed = randomSongId,
                Rates = Repository.GetRates()
            };

            if (mainPage.RatesSelected != 0)
                Repository.SaveRateRules(mainPage.SongPlayed, mainPage.RatesSelected);

            ViewBag.Title = Radio;
            return View(songViewModel);
        }

    }
}
