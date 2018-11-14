using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks

        public string Detail()
        {
            return "Hello from the comic books controller";
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}