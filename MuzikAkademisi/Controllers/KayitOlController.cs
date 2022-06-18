using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    [AllowAnonymous]
    public class KayitOlController : Controller
    {

        MuzikAkademisiContext db = new MuzikAkademisiContext();
       
        // GET: KayitOl
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Kayit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kayit(Uye pUye)
        {
          
                db.Uye.Add(pUye);
                db.SaveChanges();
                Session["UyeId"] = pUye.UyeId;
                return RedirectToAction("Index","Home");
            
            
            
           
        }
    }
}