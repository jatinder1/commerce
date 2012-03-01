using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commerce.BLL.Models
{
    class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderNumber { get; set; }
        public decimal Price { get; set; }
        public decimal? Qty { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public bool FullFilled { get; set; }
        public DateTime ShipDate { get; set; }
        public int ShiperId { get; set; }
        public int OrderDetailId { get; set; }
        public DateTime BillDate { get; set; }
    }
}
