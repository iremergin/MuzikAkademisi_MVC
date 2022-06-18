using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    public class MagazaController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: Magaza
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(MuzikAleti pMuzikAleti)
        {
            MuzikAleti mzk = new MuzikAleti();
            mzk.MuzikAletiFotograf = pMuzikAleti.MuzikAletiFotograf;
            mzk.MuzikAletiAciklama = pMuzikAleti.MuzikAletiAciklama;
            mzk.MuzikAletiFiyat = pMuzikAleti.MuzikAletiFiyat;
            mzk.MuzikAletiDurumu = true;

            db.MuzikAleti.Add(mzk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            MuzikAleti mzk = db.MuzikAleti.Find(id);
            db.MuzikAleti.Remove(mzk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            MuzikAleti mzk = db.MuzikAleti.Find(id);
            return View(mzk);
        }
        [HttpPost]
        public ActionResult Guncelle(MuzikAleti pMuzikAleti)
        {
            MuzikAleti mzk = db.MuzikAleti.Find(pMuzikAleti.MuzikAletiId);
            mzk.MuzikAletiFotograf = pMuzikAleti.MuzikAletiFotograf;
            mzk.MuzikAletiAciklama = pMuzikAleti.MuzikAletiAciklama;
            mzk.MuzikAletiFiyat = pMuzikAleti.MuzikAletiFiyat;
            mzk.MuzikAletiDurumu = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            var muzikAletleri = db.MuzikAleti.AsNoTracking().Where(m => m.MuzikAletiDurumu == true);

            return View(muzikAletleri.ToList());
        }
    }
}