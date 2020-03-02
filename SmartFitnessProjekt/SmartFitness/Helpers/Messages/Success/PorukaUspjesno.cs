using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitness.Helpers.Messages.Success
{
    public static class PorukaUspjesno
    {
        public static string Zaglavlje => "Uspjesno";
        public static string ZaglavljeUspjesnoAzurirano => "Azuriranje!";
        public static string UspjesnoAzurirano => "Uspjesno azuriran!";


        #region Natjecanje_NatjecanjeUcenika

        public static string UspjesnoDodanoNatjecanje => "Uspjesno dodano natjecanje!";
        public static string UspjesnoDodananUcenikNaNatjecanje => "Ucenik uspjesno dodan na natjecanje!";
        public static string UspjesnoObrisanoNatjecanjeUcenika => "Uspjesno obrisano natjecanje ucenika!";


        #endregion

        #region RezultatVjezbe

        public static string UspjesnoDodanRezultatVjezbe => "Uspjesno dodan trening uceniku!";

        #endregion

        #region Sport

        public static string UspjesnoAzuriranSport => "Uspjesno azuriran sport!";

        #endregion

        #region Vjezba

        public static string UspjesnoAzuriranaVjezba => "Uspjesno azuriran vjezba!";
        public static string ObrisanaVjezba => "Uspjesno obrisana vjezba!";

        #endregion

        #region Ucenik

        public static string AzuriranjeUcenika => "Ucenik uspjesno azuriran!";
        public static string DodanUcenik => "Uspjesno dodan ucenik!";

        #endregion

        #region Sport

        public static string DodanSport => "Uspješno dodan sport!";

        #endregion
    }
}
