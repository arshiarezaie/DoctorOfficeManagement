//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoctorTask
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int VisistID { get; set; }
        public int TaskID { get; set; }
    
        public virtual Task Task { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual Person Person { get; set; }
    }
}