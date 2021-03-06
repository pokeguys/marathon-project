//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarathonSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Marathon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Marathon()
        {
            this.Checkpoints = new HashSet<Checkpoint>();
            this.MarathonEvents = new HashSet<MarathonEvent>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string country_id { get; set; }
        public Nullable<int> hold_at { get; set; }
        public string map { get; set; }
        public string logo { get; set; }
        public string seal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Checkpoint> Checkpoints { get; set; }
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarathonEvent> MarathonEvents { get; set; }
    }
}
