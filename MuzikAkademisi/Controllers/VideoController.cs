using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    public class VideoController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: Video
        public ActionResult Index(int id, string path)
        {
           
            try
            {
                Session["KursId"] = id;
                ViewBag.VideoPath = path;
                var video = db.Video.Where(x => x.KursId == id).ToList();
                if (path == null)
                {
                    ViewBag.VideoPath = video[0].VideoPath;
                }
               
                return View(video.ToList());
            }
            catch 
            {
                var video = db.Video.Where(x => x.KursId == id).ToList();
                
                return View(video.ToList());
            }
       
        }


        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Video pVideo)
        {

            Video video = new Video();
            video.VideoDurumu = true;
            video.VideoAdi = pVideo.VideoAdi;
            video.VideoBolum = pVideo.VideoBolum;
            video.VideoKonu = pVideo.VideoKonu;
            pVideo.KursId = Convert.ToInt32(Session["KursId"]);



            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string yol = "~/Videos/" + dosyaadi;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                pVideo.VideoPath = "/Videos/" + dosyaadi;
            }




            db.Video.Add(pVideo);
            db.SaveChanges();

            
            return RedirectToAction("Index", "Video", new { id = pVideo.KursId });
        }

        public ActionResult Sil(int id)
        {
            try
            {
                Video video = db.Video.Find(id);
                db.Video.Remove(video);
                db.SaveChanges();
                int KursId = Convert.ToInt32(Session["KursId"]);

                return RedirectToAction("Index", "Video", new { id = KursId });
            }
            catch 
            {
                int KursId = Convert.ToInt32(Session["KursId"]);
                ViewBag.Hata = "Silmek istediğiniz dersi seçiniz !";
                return RedirectToAction("Index", "Video", new { id = KursId, ViewBag.Hata }) ;
            }
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            if (Convert.ToInt32( Session["VideoId"] ) == 0)
            {
                int KursId = Convert.ToInt32(Session["KursId"]);
                Session["Hata"] = "Güncellemek istediğiniz dersi seçiniz !";
                return RedirectToAction("Index", "Video", new { id = KursId });
            }
            try
            {
                Video video = db.Video.Find(id);
                Session["VideoId"] = 0;
                Session["Hata"] = " ";

                return View(video);
            }
            catch 
            {

                int KursId = Convert.ToInt32(Session["KursId"]);
                ViewBag.Hata = "Güncellemek istediğiniz dersi seçiniz !";
                return RedirectToAction("Index", "Video", new { id = KursId, ViewBag.Hata });
            }
            
        }


        [HttpPost]
        public ActionResult Guncelle(Video pVideo)
        {
            try
            {
                
                Video video = db.Video.Find(pVideo.VideoId);
                video.VideoAdi = pVideo.VideoAdi;
                video.VideoBolum = pVideo.VideoBolum;
                video.VideoKonu = pVideo.VideoKonu;
                pVideo.KursId = Convert.ToInt32(Session["KursId"]);
                video.VideoDurumu = true;
                db.SaveChanges();
                int KursId = Convert.ToInt32(Session["KursId"]);
                Session["VideoId"] = 0;
                return RedirectToAction("Index", "Video", new { id = KursId});
            }
            catch 
            {
                int KursId = Convert.ToInt32(Session["KursId"]);
                ViewBag.Hata = "Güncellemek istediğiniz dersi seçiniz !";
                return RedirectToAction("Index", "Video", new { id = KursId, ViewBag.Hata });
            }
        }

        public ActionResult VideoOynat (int id)
        {

            Video video = db.Video.Find(id);

            Session["VideoId"] = video.VideoId;

            int KursId = Convert.ToInt32( Session["KursId"] );

            return RedirectToAction("Index", "Video", new { id = KursId, path = video.VideoPath });
        }

    }
}