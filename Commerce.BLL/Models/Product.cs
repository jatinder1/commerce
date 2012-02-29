using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commerce.BLL.Models
{
    class Product
    {
        public int ProductId { get; set; }
        public int VendorProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public decimal? QtyPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal MSRP { get; set; }
        public string AvailableSize { get; set; }
        public string AvailableColor { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal? Discount { get; set; }
        public decimal UnitWeight { get; set; }
        public decimal UnitInStock { get; set; }
        public decimal UnitOnOrder { get; set; }
        public string ReOrderLavel { get; set; }
        public string ProductAvailable { get; set; }
        public decimal? DiscountAvailable { get; set; }
        public string CurrentOrder { get; set; }
        public string Picture { get; set; }
        public decimal Ranking { get; set; }
        public string Note { get; set; }
    }
}
