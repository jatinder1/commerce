﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Commerce.Web.Models;
using System.Data.Entity;

namespace Commerce.Web.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactFName { get; set; }
        public string ContactTitle { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string URL { get; set; }
        public string PaymentType { get; set; }
        public string PaymentMethod { get; set; }
        public string DiscountType { get; set; }
        public decimal? discount { get; set; }
        public string Currentorder { get; set; }
        public int CustomerId { get; set; }
        public string sizeUrl { get; set; }
    }

}