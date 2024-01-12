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
    
    public partial class MedicareProduct
    {
        public int MedicareProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public Nullable<decimal> MinBenefit { get; set; }
        public Nullable<decimal> MaxBenefit { get; set; }
        public string Sponsor { get; set; }
        public Nullable<int> ProductGroup { get; set; }
        public Nullable<int> ProductSubGroup { get; set; }
        public string Suffix { get; set; }
        public string Note { get; set; }
        public string Change { get; set; }
        public string DeleteComment { get; set; }
    
        public virtual MedicareGroup MedicareGroup { get; set; }
        public virtual MedicareProductSponsor MedicareProductSponsor { get; set; }
        public virtual MedicareSubGroup MedicareSubGroup { get; set; }
    }
}
