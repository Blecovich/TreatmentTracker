//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TreatmentTrackerRepo
{
    using System;
    using System.Collections.Generic;
    
    public partial class treatment_DL
    {
        public int id { get; set; }
        public string treatment_description { get; set; }
        public Nullable<decimal> every_x_hours { get; set; }
        public Nullable<int> max_per_day { get; set; }
        public Nullable<long> start_time { get; set; }
    }
}