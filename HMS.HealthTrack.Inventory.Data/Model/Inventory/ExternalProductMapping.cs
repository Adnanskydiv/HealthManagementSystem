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
    
    public partial class ExternalProductMapping
    {
        public int ProductMappingId { get; set; }
        public HMS.HealthTrack.Web.Data.Model.Inventory.ProductMappingSource ProductSource { get; set; }
        public int ExternalProductId { get; set; }
        public int InventoryProductId { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
