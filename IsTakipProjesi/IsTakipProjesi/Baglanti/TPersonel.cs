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
    
    public partial class TPersonel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TPersonel()
        {
            this.TGorev = new HashSet<TGorev>();
            this.TGorev1 = new HashSet<TGorev>();
            this.TGorev2 = new HashSet<TGorev>();
            this.TCagri = new HashSet<TCagri>();
        }
    
        public byte ID { get; set; }
        public string Personel { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Gorsel { get; set; }
        public Nullable<byte> Departman { get; set; }
        public Nullable<bool> Durum { get; set; }
        public string Sifre { get; set; }
    
        public virtual TDepartman TDepartman { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TGorev> TGorev { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TGorev> TGorev1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TGorev> TGorev2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TCagri> TCagri { get; set; }
    }
}
