//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Towar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Towar()
        {
            this.PozycjaFaktury = new HashSet<PozycjaFaktury>();
        }
    
        public int IdTowaru { get; set; }
        public string Kod { get; set; }
        public string Nazwa { get; set; }
        public Nullable<decimal> StawkaVatZakupu { get; set; }
        public Nullable<decimal> StawkaVatSprzedazy { get; set; }
        public Nullable<decimal> Marża { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PozycjaFaktury> PozycjaFaktury { get; set; }
    }
}