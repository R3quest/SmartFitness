using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unos_sporta
{
    public class Prijava
    {
        public static bool ProvjeraPrijave(string korisnickoIme, string lozinka)
        {
            if (korisnickoIme.Equals("korisnik") && lozinka.Equals("korisnik"))
            {
                return true;
            }
            return false;
        }
    }
}
