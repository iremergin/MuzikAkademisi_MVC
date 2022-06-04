using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    public class SepetController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: Sepet




        public ActionResult Index()
        {
       

            var sepet2 = db.Sepet.AsNoTracking();

            return View(sepet2.ToList());
        }


        public ActionResult Sil(int id)
        {
            Sepet spt = db.Sepet.Find(id);
            db.Sepet.Remove(spt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        //Kurs ekleme alanı
        public ActionResult Ekle(int id)
        {

            int uyeId = Convert.ToInt16(Session["UyeId"]);
            Sepet sepet = new Sepet();

            Kurs kurss = db.Kurs.Find(id);
            sepet.KursId = kurss.KursId;
            sepet.UyeId = uyeId;

            db.Sepet.Add(sepet);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        //login olan üyeden al



        //Müzik aleti ekleme alanı
        public ActionResult Ekle2(int id)
        {
          
            int uyeId = Convert.ToInt16(Session["UyeId"]);
           
            Sepet sepet = new Sepet();

            MuzikAleti muzik = db.MuzikAleti.Find(id);
            sepet.MuzikAletiId = muzik.MuzikAletiId;
            sepet.UyeId = uyeId;
            db.Sepet.Add(sepet);
            db.SaveChanges();

            return RedirectToAction("Index");
        }



    }
}