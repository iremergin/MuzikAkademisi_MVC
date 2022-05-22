using MuzikAkademisi.Entities.Mapping;
using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
   
    public class HomeController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();

        
        public ActionResult Index(string id)
        {

            DuyuruProgramCizelgesi dyr = new DuyuruProgramCizelgesi();

            int kullaniciId = Convert.ToInt16(Session["UyeId"]);
            dyr.Duyuru = db.Duyuru.ToList();
            dyr.ProgramCizelgesi = db.ProgramCizelgesi.AsNoTracking().Where(x => x.Gun == id && x.UyeId==kullaniciId).ToList();

            return View(dyr);
        }


        public ActionResult Ekle(Duyuru pDuyuru)
        {


            Duyuru duyuru = new Duyuru();
            duyuru.DuyuruAdi = pDuyuru.DuyuruAdi;
            duyuru.DuyuruAciklama = pDuyuru.DuyuruAciklama;
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



        [HttpPost]
        public ActionResult Guncelle(Duyuru pDuyuru)
        {
            Duyuru duyuru = db.Duyuru.Find(pDuyuru.DuyuruId);
            duyuru.DuyuruAdi = pDuyuru.DuyuruAdi;
            duyuru.DuyuruAciklama = pDuyuru.DuyuruAciklama;
            duyuru.DuyuruDurumu = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}