
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections;

namespace SmartFitness.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;


    public partial class vjezba
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public vjezba()
    {

        this.vjezba_ucenik = new HashSet<vjezba_ucenik>();

    }


    public int id_vjezbe { get; set; }

    public string naziv { get; set; }

    public string opis { get; set; }

    public Nullable<int> vrijeme_vjezbanja { get; set; }

    public Nullable<int> ponavljanja { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<vjezba_ucenik> vjezba_ucenik { get; set; }

        public static BindingList<vjezba> DohvatiVjezbe()
        {
            BindingList<vjezba> listaVjezbi = null;
            using (var db = new SmartFitnessEntities())
            {
                listaVjezbi = new BindingList<vjezba>(db.vjezbas.ToList());
            }
            return listaVjezbi;
        }

        public static BindingList<vjezba> DohvatiVjezbeUcenika(ucenik ucenik)
        {
            BindingList<vjezba> listaVjezbi = null;
            using (var db = new SmartFitnessEntities())
            {
                var vjezbeUcenika = db.vjezba_ucenik
                    .Where(b => b.ucenik.id_ucenika == ucenik.id_ucenika)
                    .Select(u => u.vjezba)
                    .Distinct().ToList();
                listaVjezbi = new BindingList<vjezba>(vjezbeUcenika);
            }
            return listaVjezbi;
        }

        public static BindingList<vjezba> DohvatiVjezbeUcenika(int ucenikId)
        {
            BindingList<vjezba> listaVjezbi = null;
            using (var db = new SmartFitnessEntities())
            {
                var vjezbeUcenika = db.vjezba_ucenik
                    .Where(b => b.ucenik.id_ucenika == ucenikId)
                    .Select(u => u.vjezba)
                    .Distinct().ToList();
                listaVjezbi = new BindingList<vjezba>(vjezbeUcenika);
            }
            return listaVjezbi;
        }

        public static ArrayList DohvatiVjezbePoDatumu(int idUcenika, DateTime datumOd, DateTime datumDo)
        {
            ArrayList list = new ArrayList();
            using (var db = new SmartFitnessEntities())
            {

                var lista =
                    (from su in db.vjezba_ucenik
                     join s in db.vjezbas on su.vjezba_id_vjezbe equals s.id_vjezbe
                     join u in db.uceniks on su.ucenik_id_ucenika equals u.id_ucenika
                     where u.id_ucenika == idUcenika && su.datum >= datumOd && su.datum <= datumDo
                     select new
                     {
                         Id = u.id_ucenika,

                         Naziv = s.naziv,
                         Vrijeme = s.vrijeme_vjezbanja,
                         Ponavljanja_Duljina = su.ostvareno_ponavljanja,
                         Datum = su.datum
                     }).ToList();
                list.AddRange(lista);
            }
            return list;
        }

        public static vjezba DohvatiVjezbuPoIdu(int vjezbaId)
        {
            vjezba vjezba = null;
            using (var db = new SmartFitnessEntities())
            {
                vjezba = db.vjezbas.FirstOrDefault(o => o.id_vjezbe == vjezbaId);
            }
            return vjezba;
        }

        public static void DodajVjezbu(string naziv, string opis, int vrijemeVjezbanja, int brojPonavljanja)
        {
            using (var db = new SmartFitnessEntities())
            {
                vjezba vjezba = new vjezba
                {
                    naziv = naziv,
                    opis = opis,
                    vrijeme_vjezbanja = vrijemeVjezbanja,
                    ponavljanja = brojPonavljanja

                };
                db.vjezbas.Add(vjezba);
                db.SaveChanges();
            }
        }

        public static void AzurirajVjezbu(vjezba vjezba, string naziv, string opis, int vrijeme, int brojPonavljanja)
        {
            using (var db = new SmartFitnessEntities())
            {
                vjezba.naziv = naziv;
                vjezba.opis = opis;
                vjezba.ponavljanja = brojPonavljanja;
                vjezba.vrijeme_vjezbanja = vrijeme;
                db.SaveChanges();
            }
        }

        public static void ObrisiVjezbu(int vjezbaId)
        {
            using (var db = new SmartFitnessEntities())
            {
                var _vjezba = db.vjezbas.FirstOrDefault(o => o.id_vjezbe == vjezbaId);
                db.vjezbas.Attach(_vjezba);
                db.vjezbas.Remove(_vjezba);
                db.SaveChanges();
            }
        }

    }

}
