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
    
    public partial class vjezba_ucenik
    {
        public int id_vjezba_ucenik { get; set; }
        public int vjezba_id_vjezbe { get; set; }
        public int ucenik_id_ucenika { get; set; }
        public System.DateTime datum { get; set; }
        public int ostvareno_ponavljanja { get; set; }
    
        public virtual ucenik ucenik { get; set; }
        public virtual vjezba vjezba { get; set; }
    }
}