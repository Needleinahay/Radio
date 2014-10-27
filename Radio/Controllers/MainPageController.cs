using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data_layer;

namespace Radio.Controllers
{
    public class MainPageController : Controller
    {
        private Repository repository;
        public MainPageController()
        {
            repository = new Repository(new RadioContext());
        }
        //
        // GET: /MainPage/

        public ActionResult Index()
        {
            var toView = repository.GetMainPage();
            return View(toView);
        }

    }
}
