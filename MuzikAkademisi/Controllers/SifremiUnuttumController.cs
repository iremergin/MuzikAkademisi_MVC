using MuzikAkademisi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MuzikAkademisi.Controllers
{
    [AllowAnonymous]
    public class SifremiUnuttumController : Controller
    {
        
        MuzikAkademisiContext db = new MuzikAkademisiContext();
        // GET: SifremiUnuttum
                public ActionResult Index(Uye uye)
                {

                var uyes = db.Uye.FirstOrDefault(x => x.UyeMail == uye.UyeMail);
                if (uyes != null)
                {
                string email = uye.UyeMail;
                string sifre = uyes.UyeSifre;
                string name = uyes.UyeAdi;
                string surname = uyes.UyeSoyadi;
                Mail mails = new Mail();
                string mesaj = mails.Gonder(email, sifre, name, surname);
                ViewBag.Mesaj = mesaj;
                }
                else if (uye.UyeMail != null)
                {



                ViewBag.Mesaj = "Mail Adresiniz Kayıtlı Değil!";



                }



                else {


                }

                return View();





                }



                public class Mail
                {
                public string Gonder(string email,string sifre,string name,string surname)
                {
                try
                {




                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("akademimuzikss@gmail.com", "icxqgbpmcpzeduwk");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;



                mail.IsBodyHtml = true;
                mail.From = new MailAddress("akademimuzikss@gmail.com", "Şifre Yenileme İşlemi!");
                mail.To.Add(email);
                mail.IsBodyHtml = true;
                mail.Subject ="Sisteme Kayıtlı Olan Şifreniz:";
                mail.Body = "<b>Merhaha" + " "+name+" "+surname+" "+"şifreniz"+" </b>"+"<i>"+sifre+"</i>";
                smtp.Send(mail);



                return "Şifreniz kayıtlı olan e-mail adresinize gönderildi!";



                }



                catch
                {
                return "Sistemsel bir hata oluştur lütfen daha sonra tekrar deneyin!";

                }




                }



                }

                    }
                }