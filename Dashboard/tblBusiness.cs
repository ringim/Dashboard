//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dashboard
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBusiness
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBusiness()
        {
            this.tblPersonalDetails = new HashSet<tblPersonalDetail>();
        }
    
        public int ID { get; set; }
        public string Training { get; set; }
        public string BusinessType { get; set; }
        public string Amount { get; set; }
        public string NatureofBusiness { get; set; }
        public string IntroducedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPersonalDetail> tblPersonalDetails { get; set; }
    }
}
