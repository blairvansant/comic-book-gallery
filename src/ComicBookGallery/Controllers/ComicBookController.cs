using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller  //ComicBooks is the name of the controller
    {
        public ActionResult Detail() //Detail() action method , url path: .../ComicBooks/Detail
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }
            return Content ("Hello from the comic books controller!");
        }

    }
}
