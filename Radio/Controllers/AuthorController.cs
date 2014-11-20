using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Data_layer;

namespace Radio.Controllers
{
    public class AuthorController : Controller
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

        public AuthorController()
        {
            _repository = new Repository(new RadioContext());
        }

        #endregion

      
        public ActionResult Create()
        {
            var mainPage = Repository.GetMainPage();
            CreateAuthorVM createAuthorVM = new CreateAuthorVM();
            createAuthorVM.Author = new Author();
            createAuthorVM.Countries = mainPage.Countries;
            createAuthorVM.Genres = mainPage.Genres;
            return View(createAuthorVM);
        }

        //
        // POST: /Author/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateAuthorVM author)
        {
            Repository.SaveAuthor(author.Author);
            return View(author);
        }

        //
        // GET: /Author/Edit/5

        public ActionResult Edit(int id = 0)
        {
            return View(Repository.GetAuthor(id));
        }

        //
        // POST: /Author/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Author author)
        {
            Repository.SaveAuthor(author);
            return View(author);
        }

    }
}