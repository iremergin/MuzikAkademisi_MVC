using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MuzikAkademisi.Controllers
{
    public class ProfilController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: Profil
        public ActionResult Index()
        {
            string kId = @Session["UyeId"].ToString();
            int kullaiciId = Convert.ToInt32(kId);

            UyeMuzikAletiKurs uma = new UyeMuzikAletiKurs();
            
            var profil = db.UyeMuzikAletiKurs.AsNoTracking().Where(x => x.UyeId==kullaiciId);
          
            return View(profil.ToList());
      
        }
        public ActionResult Sil(int id)
        {
            UyeMuzikAletiKurs uyk = db.UyeMuzikAletiKurs.Find(id);
            db.UyeMuzikAletiKurs.Remove(uyk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Ekle(int id)
        {
            UyeMuzikAletiKurs uma = new UyeMuzikAletiKurs();
            string kId = @Session["UyeId"].ToString();
            int kullaiciId = Convert.ToInt32(kId);

            Kurs kurss = db.Kurs.Find(id);
            uma.KursId = kurss.KursId;
            
            uma.UyeId = kullaiciId;
            db.UyeMuzikAletiKurs.Add(uma);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Ekle2(int id)
        {
            UyeMuzikAletiKurs uma = new UyeMuzikAletiKurs();
            string kId = @Session["UyeId"].ToString();
            int kullaiciId = Convert.ToInt32(kId);

            MuzikAleti mzkAlet = db.MuzikAleti.Find(id);
            uma.MuzikAletiId = mzkAlet.MuzikAletiId;

            uma.UyeId = kullaiciId;
            db.UyeMuzikAletiKurs.Add(uma);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}