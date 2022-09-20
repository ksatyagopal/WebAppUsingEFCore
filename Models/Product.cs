using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppUsingEFCore.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Cost { get; set; }
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
