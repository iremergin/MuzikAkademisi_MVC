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
        public ActionResult Index()
        {
            if (Session["Path"] == null)
            {
                Session["Path"] = " ";
            }
            var video = db.Video.AsNoTracking();
            return View(video.ToList());
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
            video.KursId = pVideo.KursId;



            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string yol = "~/Videos/" + dosyaadi;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                pVideo.VideoPath = "/Videos/" + dosyaadi;
            }




            db.Video.Add(pVideo);
            db.SaveChanges();

            
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            Video video = db.Video.Find(id);
            db.Video.Remove(video);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            Video video = db.Video.Find(id);

            return View(video);
        }


        [HttpPost]
        public ActionResult Guncelle(Video pVideo)
        {
            Video video = db.Video.Find(pVideo.VideoId);
            video.VideoAdi = pVideo.VideoAdi;
            video.VideoBolum = pVideo.VideoBolum;
            video.VideoKonu = pVideo.VideoKonu;
            video.VideoPath = pVideo.VideoPath;
            video.KursId = pVideo.KursId;
            video.VideoDurumu = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult VideoOynat (int id)
        {
            Video video = db.Video.Find(id);
            Session["Path"] = video.VideoPath;

            return RedirectToAction("Index");
        }

    }
}