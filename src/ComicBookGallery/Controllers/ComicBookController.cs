using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller  //ComicBooks is the name of the controller
    {
        private ComicBookRepository _comicBookRepository = null;  //_comic... naming convention for private methods

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id) //Detail() action method , url path: .../ComicBooks/Detail
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook(id.Value);
      


            return View(comicBook);
        }

    }
}
