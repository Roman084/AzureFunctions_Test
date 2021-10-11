using System;
using System.Collections.Generic;

namespace FunctionApp.Data.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string Company_name { get; set; }
        public string Business_id { get; set; }
        public string Person_to_contact { get; set; }
        public string Person_to_contact_email { get; set; }
        public string Delivery_address { get; set; }
        public string Zip_code { get; set; }
        public string City { get; set; }
        public string Web_invoice { get; set; }
        public string Finvoice_operator { get; set; }
        public string Delivery_method { get; set; }
        public string Customer_type { get; set; }
        
        public ICollection<Invoice> Invoice { get; set; }
    }
}