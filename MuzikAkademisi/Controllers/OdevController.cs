using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.IO;
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

            Session["OdevId"] = id;
            int kullaniciId = Convert.ToInt32(Session["UyeId"]);
            int odvId = Convert.ToInt32(Session["OdevId"]);

            var bilgi = db.YuklenenOdevler.Where(x => x.UyeId == kullaniciId && x.OdevId == odvId);
            
            
            
            return View(odev);


        }


        public ActionResult OdevYukleme(YuklenenOdevler yuklenenOdevler) {
            YuklenenOdevler yuklenenOdevlers = new YuklenenOdevler();

            int kullaniciId = Convert.ToInt32(Session["UyeId"]);
            yuklenenOdevlers.Uye = db.Uye.Find(kullaniciId);
            int odvId = Convert.ToInt32(Session["OdevId"]);
            yuklenenOdevler.OdevId = odvId;
            yuklenenOdevler.UyeId = kullaniciId;

            yuklenenOdevlers.OdevId = yuklenenOdevler.OdevId;
            yuklenenOdevlers.UyeId = yuklenenOdevler.UyeId;

            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string yol = "~/Image/" + dosyaadi;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                yuklenenOdevler.DosyaYolu = "/Image/" + dosyaadi;
            }

            db.YuklenenOdevler.Add(yuklenenOdevler);
            db.SaveChanges();

            return RedirectToAction("Index");


        }
    }
}