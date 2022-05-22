using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MuzikAkademisi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GirisYap() {

            return View();
        }
       


        [HttpPost]
        public ActionResult GirisYap(Uye pUye)
        {
            pUye.UyeKullaniciAdi = pUye.UyeMail;
            using (MuzikAkademisiContext db = new MuzikAkademisiContext())
            {
                var uye = db.Uye.FirstOrDefault(x => (x.UyeMail == pUye.UyeMail || x.UyeKullaniciAdi == pUye.UyeKullaniciAdi) && x.UyeSifre == pUye.UyeSifre);

                if (uye != null)
                {
                    //Sisteme Login Olunuldu
                    //Sayfalar Arası Veri Taşır.

                    FormsAuthentication.SetAuthCookie(uye.UyeMail, false);
                    Session["UyeId"] = uye.UyeId;
                    Session["yetki"] = uye.UyeTuru;




                    return RedirectToAction("Index", "Home", new { id = "PAZARTESİ" });



                }

                //else
                //{

                //    ViewBag.Message = "E-mail yada sifre yanlış";
                //    return View();
                //}

             
                return RedirectToAction("Index");



            }
                
        }
    }
}