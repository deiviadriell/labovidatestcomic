using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;
        private pruebaEntities db = new pruebaEntities();

        // constructor -  no return value and shares the same name as the class name
        public ComicBooksController ()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        // index - list page
        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }
        public ActionResult Dashboard()
        {
            return View();
        }        
        public ActionResult Busqueda()
        {
            var ventas = (from c in db.comic
                          select new Result
                          {
                              nombre = c.nombre,
                              fecha = c.fecha
                          }).ToList();
            return View("Dashboard", ventas);
        }

        // allow nullable
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);

            // strongly typed view - by putting object into the view vs. ViewBag.ComicBook = comicBook;
            return View(comicBook);  // will automatically look in the views folder
        }

        public ActionResult Detail2()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                // return new RedirectResult("/");
                return Redirect("/");
            }

            //return new ContentResult()
            //{
            //    Content = "This is a test."
            //};
            return Content("This is a test.");
        }
        public FileResult DownloadFile()
        {
            var sDocument = Server.MapPath("../los_vengadores_acoso_nunca_mas_marvel_panini_is4k.pdf");
            byte[] fileBytes = System.IO.File.ReadAllBytes(sDocument);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "Descarga.pdf");
        }
      
       



    }
}