using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    public class OdemeKursMuzikAletiController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: OdemeKursMuzikAleti
        public ActionResult Index()
        {
             var okm = db.OdemeKursMuzikAleti.AsNoTracking();

            return View(okm.ToList());
        }

        public ActionResult Sil(int id)
        {
            OdemeKursMuzikAleti okm = db.OdemeKursMuzikAleti.Find(id);
            db.OdemeKursMuzikAleti.Remove(okm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Ekle(int id)
        {
            OdemeKursMuzikAleti okm = new OdemeKursMuzikAleti();

            Kurs kurss = db.Kurs.Find(id);
            okm.KursId = 6;
            okm.MuzikAletiId =1;
            okm.OdemeId = 2;
            db.OdemeKursMuzikAleti.Add(okm);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        //login olan üyeden al
        public ActionResult Ekle2(int id)
        {
            OdemeKursMuzikAleti okm = new OdemeKursMuzikAleti();

            MuzikAleti muzik = db.MuzikAleti.Find(id);
            okm.MuzikAletiId = muzik.MuzikAletiId;
            okm.KursId = 6;
  

            db.OdemeKursMuzikAleti.Add(okm);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}