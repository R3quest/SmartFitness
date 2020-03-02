using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitness.Helpers.Messages.Error
{
    public static class PorukaPogreska
    {
        public static string Zaglavlje => "Pogreska";
        public static string ProvjeritePopunjenostForme => "Provjerite popunjenost forme!";
        public static string NeispravanUnosPodataka => "Provjerite valjanost unesenih podataka!";
        public static string AdministratorPogreska => "Dogodila se greska kontaktirajte administratora!";



        #region Natjecanje

        public static string NisteOdabraliNatjecanje => "Niste odabrali natjecanje!";
        public static string NatjecanjeNijeOznaceno => "Provjerite ako je natjecanje oznaceno!";
        public static string UcenikVecDodanNaNatjecanje => "Ucenik je vec dodan na odabrano natjecanje!";

        public static string DodavanjeUcenikaNaNatjecanje =>
            "Dogodila se greska prilikom dodavanja ucenika na natjecanje, provjerite ako je odabrano natjecanje!";



        #endregion

        #region RezultatVjezbe

        public static string AzuriranjeRezultataVjezbeNijeNaTreningu => "Ne mozete azurirati trening jer ucenik nije bio ni na jednom treningu!";

        #endregion

        #region DodajSportUceniku

        public static string UcenikImaOcijenu => "Uceniku ste vec dodali ocijenu, mozete ju samo azurirati!";
        public static string OcijenaNijeOdabrana => "Provjerite ako ste odabrali ocijenu!";

        #endregion

        #region OcijenaUcenika

        public static string OcijenaNijeDodana => "Uceniku morate dodati ocijenu kako bi ju mogli azurirati!";

        #endregion

        #region Vjezba

        public static string AzuriranjeVjezbe => "Pogreska prilikom azuriranja vjezbe!";
        public static string OznacenaVjezba => "Provjerite ako je vjezba oznacena!";


        #endregion

        #region Ucenik

        public static string UcenikOznacen => "Provjerite da li je ucenik oznacen!";

        #endregion

        

    }
}
