//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Joole_MVC_Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSpecification
    {
        public int TypeID { get; set; }
        public Nullable<decimal> MinValue { get; set; }
        public Nullable<decimal> MaxValue { get; set; }
        public int ProductID { get; set; }
        public int SubcategoryID { get; set; }
    
        public virtual tblProduct tblProduct { get; set; }
        public virtual tblSubcategory tblSubcategory { get; set; }
    }
}
