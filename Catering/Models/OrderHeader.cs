//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Catering.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderHeader()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int OrderHeaderId { get; set; }
        public int UserId { get; set; }
        public int PaymentStatusId { get; set; }
        public int OrderStatusId { get; set; }
        public System.DateTime OrderDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual PaymentStatus PaymentStatus { get; set; }
        public virtual User User { get; set; }
    }
}
