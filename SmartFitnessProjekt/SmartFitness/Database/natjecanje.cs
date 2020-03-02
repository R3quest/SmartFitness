
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections;
using System.ComponentModel;
using System.Linq;

namespace SmartFitness.Database
{

using System;
    using System.Collections.Generic;
    
public partial class natjecanje
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public natjecanje()
    {

        this.natjecanje_ucenik = new HashSet<natjecanje_ucenik>();

    }


    public int id_natjecanja { get; set; }

    public string opis { get; set; }

    public string razina_natjecanja { get; set; }

    public string mjesto_odrzavanja { get; set; }

    public System.DateTime datum_vrijeme { get; set; }

    public int id_sporta { get; set; }



    public virtual sport sport { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<natjecanje_ucenik> natjecanje_ucenik { get; set; }

        public static BindingList<natjecanje> DohvatiNatjecanja()
        {
            BindingList<natjecanje> listaNatjecanja = null;
            using (var db = new SmartFitnessEntities())
            {
                listaNatjecanja = new BindingList<natjecanje>(db.natjecanjes.ToList());
            }
            return listaNatjecanja;
        }

        public static void DodajNatjecanje(string opis, string razina_natjecanja, string mjesto_odrzavanja, DateTime datum_vrijeme, int sportId)
        {
            using (var db = new SmartFitnessEntities())
            {
                natjecanje natjecanje = new natjecanje
                {
                    opis = opis,
                    razina_natjecanja = razina_natjecanja,
                    mjesto_odrzavanja = mjesto_odrzavanja,
                    datum_vrijeme = datum_vrijeme,
                    id_sporta = sportId
                };
                db.natjecanjes.Add(natjecanje);
                db.SaveChanges();
            }
        }

        public static natjecanje DohvatiNatjecanjePomocuId(int idNatjecanja)
        {
            natjecanje natjecanje;
            using (var db = new SmartFitnessEntities())
            {
                natjecanje = db.natjecanjes.FirstOrDefault(n => n.id_natjecanja == idNatjecanja);
            }
            return natjecanje;
        }

        public static void AzurirajNatjecanje(natjecanje natjecanje, string opis, string razinaNatjecanja,
            string mjestoNatjecanja, DateTime datumVrijeme, int sportId)
        {
            using (var db = new SmartFitnessEntities())
            {
                natjecanje.opis = opis;
                natjecanje.razina_natjecanja = razinaNatjecanja;
                natjecanje.mjesto_odrzavanja = mjestoNatjecanja;
                natjecanje.datum_vrijeme = datumVrijeme;
                natjecanje.sport.id_sporta = sportId;
                db.SaveChanges();
            }
        }

        public static void ObrisiNatjecanje(natjecanje natjecanje)
        {
            using (var db = new SmartFitnessEntities())
            {
                db.natjecanjes.Attach(natjecanje);
                db.natjecanjes.Remove(natjecanje);
                db.SaveChanges();
            }
        }

        public static BindingList<natjecanje> DohvatiNatjecanjaPoGodiniISportu(int godina, int sportId)
        {
            BindingList<natjecanje> listaNatjecanjes = null;
            using (var db = new SmartFitnessEntities())
            {
                var natjecanjaOveGodine =
                    db.natjecanjes
                        .Where(n => n.datum_vrijeme.Year == godina
                                    && n.sport.id_sporta == sportId
                        ).ToList();
                listaNatjecanjes = new BindingList<natjecanje>(natjecanjaOveGodine);
            }
            return listaNatjecanjes;
        }

    }

}
