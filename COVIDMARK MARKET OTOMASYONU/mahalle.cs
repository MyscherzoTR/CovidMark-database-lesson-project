//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COVIDMARK_MARKET_OTOMASYONU
{
    using System;
    using System.Collections.Generic;
    
    public partial class mahalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mahalle()
        {
            this.adres = new HashSet<adres>();
        }
    
        public int mahalleID { get; set; }
        public int bolgeID { get; set; }
        public string mahalleAd { get; set; }
        public string postaKod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<adres> adres { get; set; }
        public virtual bolge bolge { get; set; }
    }
}