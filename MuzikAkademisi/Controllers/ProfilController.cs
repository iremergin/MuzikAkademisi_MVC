using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    public class ProfilController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: Profil
        public ActionResult Index()
        {
            var kurslar = db.Kurs.AsNoTracking();


            return View(kurslar.ToList());
        }
        public ActionResult MuzikAleti()
        {
            var muzikAletleri = db.MuzikAleti.AsNoTracking();


            return View(muzikAletleri.ToList());
        }

    }
}