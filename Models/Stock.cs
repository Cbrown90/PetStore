//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public Nullable<int> StockQuantity { get; set; }
        public Nullable<decimal> StockBoughtFor { get; set; }
        public Nullable<decimal> StockSellFor { get; set; }
    }
}
