//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicantManagement.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Speciality
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Speciality()
        {
            this.Application = new HashSet<Application>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsBudgetForm { get; set; }
        public int PlaceNumber { get; set; }
        public int FormOfEducationID { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Exams { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }
        public virtual FormOfEducation FormOfEducation { get; set; }
    }
}