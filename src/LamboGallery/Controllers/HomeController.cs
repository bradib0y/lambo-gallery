using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LamboGallery.Models;
using LamboGallery.Data;

namespace LamboGallery.Controllers
{
    public class HomeController : Controller
    {
        private LamboRepository _lamboRepository;

        public HomeController() { _lamboRepository = new LamboRepository(); }

        public ActionResult Index() { var l = _lamboRepository.GetLambos();
            return View(l);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null) { return View(_lamboRepository.GetLambo(-1)); }
            else { return View(_lamboRepository.GetLambo((int)id)); }
        }
    }
}
