//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Unos_sporta
{
    using System;
    using System.Collections.Generic;
    
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
    }
}
