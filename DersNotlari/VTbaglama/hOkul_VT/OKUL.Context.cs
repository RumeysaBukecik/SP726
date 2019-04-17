﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hOkul_VT
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class hOkul_VTEntities : DbContext
    {
        public hOkul_VTEntities()
            : base("name=hOkul_VTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dersler> Derslers { get; set; }
        public virtual DbSet<Ogrenciler> Ogrencilers { get; set; }
        public virtual DbSet<Ogretmenler> Ogretmenlers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Notlar> Notlars { get; set; }
    
        public virtual int Not_Güncelle(Nullable<int> not1, Nullable<int> not2, Nullable<int> index)
        {
            var not1Parameter = not1.HasValue ?
                new ObjectParameter("Not1", not1) :
                new ObjectParameter("Not1", typeof(int));
    
            var not2Parameter = not2.HasValue ?
                new ObjectParameter("Not2", not2) :
                new ObjectParameter("Not2", typeof(int));
    
            var indexParameter = index.HasValue ?
                new ObjectParameter("index", index) :
                new ObjectParameter("index", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Not_Güncelle", not1Parameter, not2Parameter, indexParameter);
        }
    
        public virtual int Not_Kaydet(Nullable<int> not1, Nullable<int> not2)
        {
            var not1Parameter = not1.HasValue ?
                new ObjectParameter("Not1", not1) :
                new ObjectParameter("Not1", typeof(int));
    
            var not2Parameter = not2.HasValue ?
                new ObjectParameter("Not2", not2) :
                new ObjectParameter("Not2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Not_Kaydet", not1Parameter, not2Parameter);
        }
    
        public virtual int Not_Sil(Nullable<int> index)
        {
            var indexParameter = index.HasValue ?
                new ObjectParameter("index", index) :
                new ObjectParameter("index", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Not_Sil", indexParameter);
        }
    
        public virtual int Ogrenci_Kaydet(string ogrenciAdi)
        {
            var ogrenciAdiParameter = ogrenciAdi != null ?
                new ObjectParameter("OgrenciAdi", ogrenciAdi) :
                new ObjectParameter("OgrenciAdi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ogrenci_Kaydet", ogrenciAdiParameter);
        }
    
        public virtual int OgrenciAdi_Güncelle(string ogrenciAdi, Nullable<int> index)
        {
            var ogrenciAdiParameter = ogrenciAdi != null ?
                new ObjectParameter("OgrenciAdi", ogrenciAdi) :
                new ObjectParameter("OgrenciAdi", typeof(string));
    
            var indexParameter = index.HasValue ?
                new ObjectParameter("index", index) :
                new ObjectParameter("index", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OgrenciAdi_Güncelle", ogrenciAdiParameter, indexParameter);
        }
    
        public virtual int OgrenciAdi_Sil(Nullable<int> index)
        {
            var indexParameter = index.HasValue ?
                new ObjectParameter("index", index) :
                new ObjectParameter("index", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OgrenciAdi_Sil", indexParameter);
        }
    
        public virtual int Ogretmen_Kaydet(string ogretmenAdi)
        {
            var ogretmenAdiParameter = ogretmenAdi != null ?
                new ObjectParameter("OgretmenAdi", ogretmenAdi) :
                new ObjectParameter("OgretmenAdi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ogretmen_Kaydet", ogretmenAdiParameter);
        }
    
        public virtual int OgretmenAdi_Güncelle(string ogretmenAdi, Nullable<int> index)
        {
            var ogretmenAdiParameter = ogretmenAdi != null ?
                new ObjectParameter("OgretmenAdi", ogretmenAdi) :
                new ObjectParameter("OgretmenAdi", typeof(string));
    
            var indexParameter = index.HasValue ?
                new ObjectParameter("index", index) :
                new ObjectParameter("index", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OgretmenAdi_Güncelle", ogretmenAdiParameter, indexParameter);
        }
    
        public virtual int OgretmenAdi_Sil(Nullable<int> index)
        {
            var indexParameter = index.HasValue ?
                new ObjectParameter("index", index) :
                new ObjectParameter("index", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OgretmenAdi_Sil", indexParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<SP_Ogrenci_Listele_Result> SP_Ogrenci_Listele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Ogrenci_Listele_Result>("SP_Ogrenci_Listele");
        }
    
        public virtual int SP_Ogretmen_Sil(Nullable<short> ogretmenID, ObjectParameter ogretmenAdi)
        {
            var ogretmenIDParameter = ogretmenID.HasValue ?
                new ObjectParameter("OgretmenID", ogretmenID) :
                new ObjectParameter("OgretmenID", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Ogretmen_Sil", ogretmenIDParameter, ogretmenAdi);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
