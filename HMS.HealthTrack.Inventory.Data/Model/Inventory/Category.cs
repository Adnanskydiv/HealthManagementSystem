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
    
    public partial class Category
    {
        public Category()
        {
            this.StockSettings = new HashSet<StockSetting>();
            this.CategoryParents = new HashSet<CategoryClosure>();
            this.CategoryChildren = new HashSet<CategoryClosure>();
            this.ProductCategories = new HashSet<ProductCategory>();
        }
    
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public string LastModifiedUser { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string UserCreated { get; set; }
        public bool Disinherit { get; set; }
    
        public virtual ICollection<StockSetting> StockSettings { get; set; }
        public virtual ICollection<CategoryClosure> CategoryParents { get; set; }
        public virtual ICollection<CategoryClosure> CategoryChildren { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
