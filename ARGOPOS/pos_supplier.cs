//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARGOPOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class pos_supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pos_supplier()
        {
            this.pos_grnheader = new HashSet<pos_grnheader>();
        }
    
        public int id { get; set; }
        public string suppliernmae { get; set; }
        public int suppliercontact { get; set; }
        public string suppliersddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pos_grnheader> pos_grnheader { get; set; }
    }
}