//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GherasEO
{
    using System;
    using System.Collections.Generic;
    
    public partial class courses
    {
        public int ID { get; set; }
        public string Course_Name { get; set; }
        public System.DateTime Course_Date { get; set; }
        public int Num_Of_Days { get; set; }
        public int Train_Hours { get; set; }
        public int type { get; set; }
        public string User_ID { get; set; }
    
        public virtual Job_seeker Job_seeker { get; set; }
    }
}
