//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mobile_DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_details
    {
        public int orderId { get; set; }
        public int user_id { get; set; }
        public int mobileId { get; set; }
        public int quantity { get; set; }
        public decimal total { get; set; }
    
        public virtual mobile_details mobile_details { get; set; }
        public virtual user_details user_details { get; set; }
    }
}