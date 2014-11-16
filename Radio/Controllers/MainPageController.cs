using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data_layer;
using Models;

namespace Radio.Controllers
{
    public class MainPageController : Controller
    {
        #region Fields

        private readonly Repository _repository;

        #endregion

        #region Ctor

        public MainPageController()
        {
            _repository = new Repository(new RadioContext());
        }

        #endregion


        public ActionResult Index()
        {
            return View(_repository.GetMainPage());
        }

        [HttpPost]
        public ActionResult Index(MainPageVM parameters)
        {
            return View();
        }

    }
}
