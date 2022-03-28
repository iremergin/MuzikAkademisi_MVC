namespace MuzikAkademisi.Entities.Model
{
    public class Mail
    {
        public int MailId { get; set; }
        public string AliciMailAdresi { get; set; }
        public string GondericiMailAdresi { get; set; }
        public string MailBaslik { get; set; }
        public string MailAciklama { get; set; }
        public char MailDurumu { get; set; }
    }
}
