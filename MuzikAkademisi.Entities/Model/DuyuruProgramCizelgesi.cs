using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikAkademisi.Entities.Model
{
    public class DuyuruProgramCizelgesi
    {
        public virtual IEnumerable<Duyuru> Duyuru { get; set; }
        public virtual IEnumerable<ProgramCizelgesi> ProgramCizelgesi { get; set; }
        public virtual IEnumerable<Kurs> kurs { get; set; }
    }
}
