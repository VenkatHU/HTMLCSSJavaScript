//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HTML_CSS_Sample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblProduct
    {
        public TblProduct()
        {
            this.TblProductOrders = new HashSet<TblProductOrder>();
            this.TblProductOrders1 = new HashSet<TblProductOrder>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<int> ProductSubcategoryKey { get; set; }
        public string Manufacturer { get; set; }
        public string BrandName { get; set; }
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public string StyleID { get; set; }
        public string StyleName { get; set; }
        public string ColorID { get; set; }
        public string ColorName { get; set; }
        public string Size { get; set; }
        public string SizeRange { get; set; }
        public string SizeUnitMeasureID { get; set; }
        public Nullable<double> Weight { get; set; }
        public string WeightUnitMeasureID { get; set; }
        public string UnitOfMeasureID { get; set; }
        public string UnitOfMeasureName { get; set; }
        public string StockTypeID { get; set; }
        public string StockTypeName { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<System.DateTime> AvailableForSaleDate { get; set; }
        public Nullable<System.DateTime> StopSaleDate { get; set; }
        public string Status { get; set; }
        public string ImageURL { get; set; }
        public string ProductURL { get; set; }
    
        public virtual TblProductSubcategory TblProductSubcategory { get; set; }
        public virtual ICollection<TblProductOrder> TblProductOrders { get; set; }
        public virtual ICollection<TblProductOrder> TblProductOrders1 { get; set; }
    }
}
