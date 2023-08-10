using BirthdayAppss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayAppss.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DavetiyeFormu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DavetiyeFormu(DavetiyeModel davetiye)
        {
            if(ModelState.IsValid)
            {
                Veritabani.Add(davetiye);
                return View("Thanks", davetiye);
            }
            return View(davetiye);
        }
        public ActionResult Katilanlar()
        {
            return PartialView(Veritabani.Liste.Where(i=>i.KatilmaDurumu==true));
        }
    }
}