using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Commerce.BLL.Models
{
    public class Order
    {
        public int OrderId {get; set;}
        public int CustomerId { get; set; }
        public decimal OrderNumber { get; set; }
        public int PaymentId { get; set; }
        public DateTime  OrderDate {get; set;}
        public DateTime ShipDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public int ShipperId { get; set; }
        public decimal Freight { get; set; }
        public decimal? SalesTax { get; set; }
        public string TimeStamp { get; set; }
        public string TransactStatus { get; set; }
        public string FullFill { get; set; }
        public string Deleted { get; set; }
        public decimal Paid { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}