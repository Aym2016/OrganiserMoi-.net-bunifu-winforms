//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetDeCours.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class personne
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personne()
        {
            this.conjointe = new HashSet<conjointe>();
            this.enfant1 = new HashSet<enfant>();
            this.parent1 = new HashSet<parent>();
            this.tacherResp = new HashSet<tacherResp>();
        }
    
        public int Id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string fonction { get; set; }
        public Nullable<System.DateTime> dateNaiss { get; set; }
        public string email { get; set; }
        public string sexe { get; set; }
        public string situation { get; set; }
        public string pass { get; set; }
        public string numTel { get; set; }
        public string parent { get; set; }
        public Nullable<int> NbEnfant { get; set; }
        public string enfant { get; set; }
        public byte[] image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<conjointe> conjointe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enfant> enfant1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<parent> parent1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tacherResp> tacherResp { get; set; }
    }
}
