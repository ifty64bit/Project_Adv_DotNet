//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            this.Offence_info = new HashSet<Offence_info>();
        }
    
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Photo { get; set; }
        public string Gender { get; set; }
        public string Date_of_birth { get; set; }
        public int Age { get; set; }
        public string Blood_group { get; set; }
        public string Father_name { get; set; }
        public string Address { get; set; }
        public int Driving_license_number { get; set; }
        public string Category { get; set; }
        public string Date_of_issue { get; set; }
        public string Validity { get; set; }
        public string Issuing_authority { get; set; }
        public string Is_wanted { get; set; }
        public string PASS { get; set; }
    
        public virtual Vehicle Vehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offence_info> Offence_info { get; set; }
    }
}
