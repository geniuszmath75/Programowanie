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
    
    public partial class PozycjaFaktury
    {
        public int IdPozycjiFaktury { get; set; }
        public Nullable<int> IdFaktury { get; set; }
        public Nullable<int> IdTowaru { get; set; }
        public Nullable<decimal> Cena { get; set; }
        public Nullable<decimal> Ilosc { get; set; }
        public Nullable<decimal> Rabat { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
    
        public virtual Faktura Faktura { get; set; }
        public virtual Towar Towar { get; set; }
    }
}
