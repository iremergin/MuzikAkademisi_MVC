using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{

    public class KursController : Controller
    {

        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: Kurs
       

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Kurs pKurs)
        {
            Kurs krs = new Kurs();
            krs.KursFotograf = pKurs.KursFotograf;
            krs.KursAdi = pKurs.KursAdi;
            //krs.Egitmen.UyeAdi = pKurs.Egitmen.UyeAdi;
            //krs.Egitmen.UyeSoyadi = pKurs.Egitmen.UyeSoyadi;
            krs.KursFiyat = pKurs.KursFiyat;
            krs.KursDurumu = true;
            db.Kurs.Add(krs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            Kurs krs = db.Kurs.Find(id);
            db.Kurs.Remove(krs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            Kurs krs = db.Kurs.Find(id);
            return View(krs);
        }

        [HttpPost]
        public ActionResult Guncelle(Kurs pKurs)
        {
            Kurs krs = db.Kurs.Find(pKurs.KursId);
            krs.KursFotograf = pKurs.KursFotograf;
            krs.KursAdi = pKurs.KursAdi;
            //krs.Egitmen.UyeAdi = pKurs.Egitmen.UyeAdi;
            //krs.Egitmen.UyeSoyadi = pKurs.Egitmen.UyeSoyadi;
            krs.KursFiyat = pKurs.KursFiyat;
            krs.KursDurumu = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            var kurslar = db.Kurs.AsNoTracking().Where(k => k.KursDurumu == true);

            return View(kurslar.ToList());

        }

    }
}