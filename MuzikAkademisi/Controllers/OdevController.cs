using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    public class OdevController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: Odev
        public ActionResult Index()
        {

            var odev = db.Odev.AsNoTracking();

            return View(odev.ToList());
        }

        public ActionResult Detay(int id)
        {

            var odev = db.Odev.Find(id);
            ViewBag.OdevAdi = odev.OdevAdi;
            ViewBag.Not = odev.OdevAciklama;
            ViewBag.OdevResim = odev.OdevFotograf;
            return View(odev);
        }
    }
}