//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS.HealthTrack.Web.Data.Model.Inventory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.Items = new HashSet<OrderItem>();
            this.Submissions = new HashSet<Submission>();
        }
    
        public int InventoryOrderId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public OrderStatus Status { get; set; }
        public bool PartialShipping { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public Nullable<int> DeliveryLocationId { get; set; }
        public Nullable<System.DateTime> NeedBy { get; set; }
        public bool IsUrgent { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<int> LedgerId { get; set; }
        public OrderSubmissionStatus OrderSubmissionStatus { get; set; }
    
        public virtual StockLocation DeliveryLocation { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; }
        public virtual GeneralLedger GeneralLedger { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
    }
}