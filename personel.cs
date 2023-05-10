using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONveCSVDosyalar
{
    internal class personel
    {
        public Guid Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return "Ad: "+Isim + " " +"Soyad: " +Soyisim+" email: "+Email;
        }

    }
}
