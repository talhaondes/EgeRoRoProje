using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string iletisimBaslik { get; set; }
        public string Adress { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string anasayfaFoto { get; set; }

    }
}
