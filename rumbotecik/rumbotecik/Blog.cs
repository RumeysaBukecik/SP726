//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rumbotecik
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blog()
        {
            this.Rel_Blog_Kategori = new HashSet<Rel_Blog_Kategori>();
        }
    
        public short BlogID { get; set; }
        public string BlogBaslik { get; set; }
        public string Blogİcerik { get; set; }
        public string BlogGorselUrl { get; set; }
        public byte BlogYazarID { get; set; }
        public Nullable<System.DateTime> BlogKayitTarih { get; set; }
        public Nullable<System.DateTime> BlogGuncellemeTarih { get; set; }
        public Nullable<bool> BlogAktif { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rel_Blog_Kategori> Rel_Blog_Kategori { get; set; }
    }
}