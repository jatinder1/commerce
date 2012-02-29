using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Commerce.Web.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public string Allowed { get; set; }
    }
}