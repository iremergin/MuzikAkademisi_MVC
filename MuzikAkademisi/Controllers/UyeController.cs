using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{

    public class UyeController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: Uye
        public ActionResult Index(string aranacakKelime)
        {
            List<Uye> uyes = db.Uye.ToList();
            if (!string.IsNullOrEmpty(aranacakKelime))
            {
                uyes = uyes.Where(x => x.UyeAdi.ToLower().Contains(aranacakKelime.ToLower()) || x.UyeSoyadi.ToLower().Contains(aranacakKelime.ToLower())).ToList();
            }

            return View(uyes);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Uye pUye)
        {
            Uye uye = new Uye();
            uye.UyeAdi = pUye.UyeAdi;
            uye.UyeSoyadi = pUye.UyeSoyadi;
            uye.UyeCinsiyet = pUye.UyeCinsiyet;
            uye.UyeDurumu = true;
            db.Uye.Add(uye);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            Uye uye = db.Uye.Find(id);
            db.Uye.Remove(uye);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            Uye uye = db.Uye.Find(id);

            return View(uye);
        }


        [HttpPost]
        public ActionResult Guncelle(Uye pUye)
        {
            Uye uye = db.Uye.Find(pUye.UyeId);
            uye.UyeAdi = pUye.UyeAdi;
            uye.UyeSoyadi = pUye.UyeSoyadi;
            uye.UyeCinsiyet = pUye.UyeCinsiyet;
            uye.UyeDurumu = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}