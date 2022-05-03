using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    public class OdemeController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: Odeme
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


        public ActionResult Sil(int id)
        {
            Kurs krs = db.Kurs.Find(id);
            db.Kurs.Remove(krs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sill(int id)
        {
            MuzikAleti mzk = db.MuzikAleti.Find(id);
            db.MuzikAleti.Remove(mzk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}