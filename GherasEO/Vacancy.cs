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
    
    public partial class Vacancy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vacancy()
        {
            this.Hired = new HashSet<Hired>();
        }
    
        public int id { get; set; }
        public int Company_ID { get; set; }
        public string Job_require { get; set; }
        public int num_vacancies { get; set; }
        public string Job_description { get; set; }
        public string Experience_required { get; set; }
        public string gender { get; set; }
        public int Experience_year { get; set; }
        public string Nature_work_time { get; set; }
        public string Work_place { get; set; }
        public decimal salary { get; set; }
        public int Age_from { get; set; }
        public int Age_to { get; set; }
    
        public virtual company company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hired> Hired { get; set; }
    }
}