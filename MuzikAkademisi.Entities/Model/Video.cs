using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Model
{
   public class Video
    {
        public int VideoId { get; set; }
        public string VideoAdi { get; set; }
        public string VideoPath { get; set; }
        public string VideoBolum { get; set; }
        public string VideoKonu { get; set; }
        public bool VideoDurumu { get; set; }
        public int KursId { get; set; }
        public virtual Kurs Kurs { get; set; }
    }
}
