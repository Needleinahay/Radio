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

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorController"/> class.
        /// </summary>
        public AuthorController()
        {
            _repository = new Repository(new RadioContext());
        }

        #endregion

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            var mainPage = Repository.GetMainPage();
            CreateAuthorVM createAuthorVM = new CreateAuthorVM();
            createAuthorVM.Countries = mainPage.Countries;
            createAuthorVM.Genres = mainPage.Genres;
            return View(createAuthorVM);
        }


        /// <summary>
        /// Creates the specified author.
        /// </summary>
        /// <param name="author">The author.</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateAuthorVM author)
        {
            Author auth = new Author
                {
                    Email = author.Email,
                    Password = author.Password,
                    CountryId = author.Country,
                    GenreId = author.Genre,
                    GeneralInfo = author.GeneralInfo,
                    LinkToSource = author.Link,
                    Name = author.Name
                };
            //Repository.SaveAuthor(auth);
            return RedirectToAction("Details", auth);
        }

        public ActionResult Details(Author author)
        {
            return View(author);
        }
        /// <summary>
        /// Logins this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View(new CreateAuthorVM());
        }

        /// <summary>
        /// Edits the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ActionResult Edit(int id = 0)
        {
            return View(Repository.GetAuthor(id));
        }


        /// <summary>
        /// Edits the specified author.
        /// </summary>
        /// <param name="author">The author.</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Author author)
        {
            //Repository.SaveAuthor(author);
            return RedirectToAction("Details", author);
        }

    }
}