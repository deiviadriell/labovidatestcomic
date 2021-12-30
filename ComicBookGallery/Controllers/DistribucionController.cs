using ComicBookGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class DistribucionController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public DistribucionController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        // GET: Distribucion
        public ActionResult Index()
        {
            var ventas = _comicBookRepository.GetVentasComics();
            return View(ventas);            
        }
    }
}