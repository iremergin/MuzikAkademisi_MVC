using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    public class ProgramCizelgesiController : Controller
    {
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: ProgramCizelgesi
        public ActionResult Index()
        {


            return View();
        }


        [HttpGet]
        public ActionResult Ekle()
        {
           List<SelectListItem>kurs = db.Kurs.AsNoTracking()
                                                        .Select(s => new SelectListItem
                                                        {
                                                        Value = s.KursId.ToString(),
                                                        Text = s.KursAdi



                                                        }).ToList();
            ViewBag.kurs = kurs;
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(ProgramCizelgesi pProgramCizelgesi)
        {
            int kullaniciId = Convert.ToInt16(Session["UyeId"]);
            ProgramCizelgesi programCizelgesi = new ProgramCizelgesi();
            programCizelgesi.Gun = pProgramCizelgesi.Gun;
            programCizelgesi.Saat = pProgramCizelgesi.Saat;
            programCizelgesi.UyeId =kullaniciId;
            programCizelgesi.Kurs = db.Kurs.Find(pProgramCizelgesi.KursId);
            db.ProgramCizelgesi.Add(programCizelgesi);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        public ActionResult Sil(int id)
        {
            ProgramCizelgesi programCizelgesi = db.ProgramCizelgesi.Find(id);
            db.ProgramCizelgesi.Remove(programCizelgesi);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            ProgramCizelgesi program = db.ProgramCizelgesi.Find(id);
            List<SelectListItem> programm = db.Kurs.AsNoTracking()
                                                       .Select(s => new SelectListItem
                                                       {
                                                           Value = s.KursId.ToString(),
                                                           Text = s.KursAdi



                                                       }).ToList();
            ViewBag.programm = programm;
        

            return View(program);
        }


        [HttpPost]
        public ActionResult Guncelle(ProgramCizelgesi pProgramCizelgesi)
        {
            int kullaniciId = Convert.ToInt16(Session["UyeId"]);
            ProgramCizelgesi program = db.ProgramCizelgesi.Find(pProgramCizelgesi.ProgramCizelgesiId);
            program.Gun = pProgramCizelgesi.Gun;
            program.Saat = pProgramCizelgesi.Saat;
            program.UyeId = kullaniciId;
            program.Kurs = db.Kurs.Find(pProgramCizelgesi.KursId);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }

    }
}