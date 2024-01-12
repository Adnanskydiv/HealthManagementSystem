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
    
    public partial class GeneralLedger
    {
        public GeneralLedger()
        {
            this.GeneralLedgerChildren = new HashSet<GeneralLedgerClosure>();
            this.GeneralLedgerParents = new HashSet<GeneralLedgerClosure>();
            this.Products = new HashSet<Product>();
            this.Orders = new HashSet<Order>();
            this.ProductImports = new HashSet<ProductImport>();
            this.StockAdjustments = new HashSet<StockAdjustment>();
        }
    
        public int LedgerId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string AlternateCode { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public int TierId { get; set; }
    
        public virtual ICollection<GeneralLedgerClosure> GeneralLedgerChildren { get; set; }
        public virtual ICollection<GeneralLedgerClosure> GeneralLedgerParents { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductImport> ProductImports { get; set; }
        public virtual GeneralLedgerTier GeneralLedgerTier { get; set; }
        public virtual ICollection<StockAdjustment> StockAdjustments { get; set; }
    }
}