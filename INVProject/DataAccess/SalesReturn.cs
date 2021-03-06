//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesReturn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesReturn()
        {
            this.SalesReturnDetails = new HashSet<SalesReturnDetail>();
        }
    
        public int ID { get; set; }
        public Nullable<int> SalesID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> NetTotal { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> ReturnedDate { get; set; }
    
        public virtual Sale Sale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesReturnDetail> SalesReturnDetails { get; set; }
    }
}
