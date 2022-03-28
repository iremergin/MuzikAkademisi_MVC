using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(Uye pUye)
        {
            pUye.UyeKullaniciAdi = pUye.UyeMail;
            using (MuzikAkademisiContext db = new MuzikAkademisiContext())
            {
                Uye uye = db.Uye.AsNoTracking().Where(x => (x.UyeMail == pUye.UyeMail || x.UyeKullaniciAdi == pUye.UyeKullaniciAdi )&& x.UyeSifre == pUye.UyeSifre).FirstOrDefault();

                if(uye != null)
                {
                    //Sisteme Login Olunuldu
                    //Sayfalar Arası Veri Taşır.

                    Session["UyeId"] = uye.UyeId;
                    return RedirectToAction("Index","Home");
                }             
            }
                return RedirectToAction("Index");
        }
    }
}