//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsTakipProjesi.Baglanti
{
    using System;
    using System.Collections.Generic;
    
    public partial class TGorev
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TGorev()
        {
            this.TGorevDetay = new HashSet<TGorevDetay>();
        }
    
        public byte ID { get; set; }
        public Nullable<byte> GorevVeren { get; set; }
        public Nullable<byte> GorevAlan { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual TPersonel TPersonel { get; set; }
        public virtual TPersonel TPersonel1 { get; set; }
        public virtual TPersonel TPersonel2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TGorevDetay> TGorevDetay { get; set; }
    }
}
