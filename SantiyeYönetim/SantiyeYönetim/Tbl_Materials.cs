//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SantiyeYönetim
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Materials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Materials()
        {
            this.Tbl_MaterialUsage = new HashSet<Tbl_MaterialUsage>();
        }
    
        public int MaterialID { get; set; }
        public string MaterialName { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> StockQuantity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_MaterialUsage> Tbl_MaterialUsage { get; set; }
    }
}
