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
    
    public partial class StatLog
    {
        public int id { get; set; }
        public Nullable<int> runner { get; set; }
        public Nullable<int> sponsorship { get; set; }
        public Nullable<int> volunteer { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    }
}