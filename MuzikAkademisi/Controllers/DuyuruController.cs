using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    public class DuyuruController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: Duyuru
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Duyuru pDuyuru)
        {
            Duyuru duyuru = new Duyuru();
            duyuru.DuyuruAdi = pDuyuru.DuyuruAdi;
            duyuru.DuyuruAciklama = pDuyuru.DuyuruAciklama;
            duyuru.DuyuruDurumu = true;
            db.Duyuru.Add(duyuru);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            Duyuru duyuru = db.Duyuru.Find(id);
            db.Duyuru.Remove(duyuru);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            Duyuru duyuru = db.Duyuru.Find(id);

            return View(duyuru);
        }


        [HttpPost]
        public ActionResult Guncelle(Duyuru pDuyuru)
        {
            Duyuru duyuru = db.Duyuru.Find(pDuyuru.DuyuruId);
            duyuru.DuyuruAdi = pDuyuru.DuyuruAdi;
            duyuru.DuyuruAciklama = pDuyuru.DuyuruAciklama;
            duyuru.DuyuruTarihi = pDuyuru.DuyuruTarihi;
            duyuru.DuyuruDurumu = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}