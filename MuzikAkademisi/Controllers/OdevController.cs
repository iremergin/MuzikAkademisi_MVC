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
            Session["Mesaj"] = " ";
            var odev = db.Odev.AsNoTracking();

            return View(odev.ToList());
        }

        public ActionResult Detay(int id)
        {
            
            Session["DosyaYolu"] = "b";
            int kullaniciId = Convert.ToInt32(Session["UyeId"]);
            var odev = db.Odev.Find(id);
            var kurs = db.YuklenenOdevler.Where(x => x.Odev.OdevId == id).ToList();
            ViewBag.Tik = "/Image/remove.png";
            for (int i = 0; i < kurs.Count; i++) {

                if (kurs[i].UyeId == kullaniciId)
                {

                    ViewBag.dosyaYolu = kurs[i].DosyaYolu;
                    Session["DosyaYolu"] = kurs[i].DosyaYolu;
                    ViewBag.Mesaj = "Ödevi Yüklediniz...";
                    ViewBag.Tik = "/Image/accept.png";
                    break;
                }

              
                
                


            }
            ViewBag.OdevAdi = odev.OdevAdi;
            ViewBag.Not = odev.OdevAciklama;
            ViewBag.OdevResim = odev.OdevFotograf;
            ViewBag.OdevVerilmeTarihi = odev.OdevVerilmeTarihi;
            ViewBag.OdevTeslimTarihi = odev.OdevTeslimTarihi;
            ViewBag.OdevId = odev.OdevId;

            Session["OdevId"] = id;
            
            
            int odvId = Convert.ToInt32(Session["OdevId"]);

            var bilgi = db.YuklenenOdevler.Where(x => x.UyeId == kullaniciId && x.OdevId == odvId);
            
            
            
            return View(odev);


        }


        public ActionResult OdevYukleme(YuklenenOdevler yuklenenOdevler) {
            YuklenenOdevler yuklenenOdevlers = new YuklenenOdevler();

            int kullaniciId = Convert.ToInt32(Session["UyeId"]);
            yuklenenOdevlers.Uye = db.Uye.Find(kullaniciId);
            int odvId = Convert.ToInt32(Session["OdevId"]);

            //odev değistirme (dosya yolu)
            var kurs = db.YuklenenOdevler.Where(x => x.Odev.OdevId == odvId).ToList();
            for (int i = 0; i < kurs.Count; i++) {
                if (kurs[i].Uye.UyeId == kullaniciId) {
                    
                    if (Request.Files.Count > 0)
                    {
                        string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                        string yol = "~/Image/" + dosyaadi;
                        Request.Files[0].SaveAs(Server.MapPath(yol));
                        kurs[i].DosyaYolu = "/Image/" + dosyaadi;

                    }

                    db.SaveChanges();

                    return RedirectToAction("Detay", "Odev", new { id = odvId });
                }
            
            }


            yuklenenOdevler.OdevId = odvId;
            yuklenenOdevler.UyeId = kullaniciId;

            yuklenenOdevlers.OdevId = yuklenenOdevler.OdevId;
            yuklenenOdevlers.UyeId = yuklenenOdevler.UyeId;


            //Odev yukleme
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string yol = "~/Image/" + dosyaadi;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                yuklenenOdevler.DosyaYolu = "/Image/" + dosyaadi;
            }

            db.YuklenenOdevler.Add(yuklenenOdevler);
            db.SaveChanges();
           

           return RedirectToAction("Detay", "Odev", new { id = odvId });


        }


        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Odev pOdev)
        {
            Odev odev = new Odev();
            odev.OdevAdi = pOdev.OdevAdi;
            odev.OdevAciklama = pOdev.OdevAciklama;
            odev.OdevFotograf = pOdev.OdevFotograf;
            odev.OdevTeslimTarihi = pOdev.OdevTeslimTarihi;
            odev.OdevVerilmeTarihi = pOdev.OdevVerilmeTarihi;
            odev.OdevDurumu = true;
            db.Odev.Add(odev);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            Odev odev = db.Odev.Find(id);
            db.Odev.Remove(odev);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            Odev odev = db.Odev.Find(id);

            return View(odev);
        }


        [HttpPost]
        public ActionResult Guncelle(Odev pOdev)
        {
            Odev odev = db.Odev.Find(pOdev.OdevId);
            odev.OdevAdi = pOdev.OdevAdi;
            odev.OdevAciklama = pOdev.OdevAciklama;
            odev.OdevFotograf = pOdev.OdevFotograf;
            odev.OdevTeslimTarihi = pOdev.OdevTeslimTarihi;
            odev.OdevVerilmeTarihi = pOdev.OdevVerilmeTarihi;
            odev.OdevDurumu = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult odevIndir() {
            int odvId = Convert.ToInt32(Session["OdevId"]);
            string yols = Session["DosyaYolu"].ToString();
            if (yols=="b")
            {
                Session["Mesaj"] = "Ödev Yüklemediniz.";
                return RedirectToAction("Detay", "Odev", new { id = odvId });
                



            }

            else {


                string yol = Session["DosyaYolu"].ToString();
                var fileName = yol;
                var filePath = "C:/Users/Pc/Desktop/MuzikAkademisi/MuzikAkademisi/MuzikAkademisi" + fileName;
                byte[] fileByts = System.IO.File.ReadAllBytes(filePath);
                return File(fileByts, "~/Css", fileName);



            }

        }

        public ActionResult odevIndir2(int id)
        {
            YuklenenOdevler odev = db.YuklenenOdevler.Find(id);

            string yol2 = odev.DosyaYolu;
            string yol = yol2;
                var fileName = yol;
                var filePath = "C:/Users/Pc/Desktop/MuzikAkademisi/MuzikAkademisi/MuzikAkademisi" + fileName;
                byte[] fileByts = System.IO.File.ReadAllBytes(filePath);
                return File(fileByts, "~/Css", fileName);



            

        }
        public ActionResult Listele(int id)
        {
            var odev = db.YuklenenOdevler.AsNoTracking().Where(x => x.OdevId == id);

            return View(odev.ToList());
        }
    }
}