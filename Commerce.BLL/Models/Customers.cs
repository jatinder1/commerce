using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Commerce.Web.Models
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address {get; set;}
        public string city {get;  set;}
        public string state {get; set;}
        public string Postalcode {get; set;}
        public string country {get ; set;}
        public string phone {get ; set;}
        public string Email {get; set;}
        public string voicemail {get; set;}
        public string password {get; set;}
        public string creditcard {get; set;}
        public int CreditcardTypeId {get; set;}
        public string CardExpMon {get; set;}
        public string CardExpYr {get; set;}
        public string BillingAddress {get; set;}
        public string BillingCity {get; set;}
        public string BillingReligion {get; set;}
        public string BillingCountry {get; set;}
        public int BillingPostalCode {get; set;}
        public string ShipAddress {get; set;}
        public string ShipCity {get; set;}
        public string ShipReligion {get; set;}
        public string ShipCountry {get; set;}
        public int ShipPostalCode {get; set;}
        public DateTime DateEntered {get; set;}
        
    }
}