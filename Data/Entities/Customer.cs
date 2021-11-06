using System;

namespace FunctionApp.Data.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string phone { get; set; }
        public int customer_id { get; set; }
        public string country { get; set; }
        public string company_name { get; set; }
        public string business_id { get; set; }
        public string person_to_contact { get; set; }
        public string person_to_contact_email { get; set; }
        public string delivery_address { get; set; }
        public string zip_code { get; set; }
        public string city { get; set; }
        public string web_invoice { get; set; }
        public string finvoice_operator { get; set; }
        public string delivery_method { get; set; }
        public string customer_type { get; set; }
        public Invoice[] invoice { get; set; }
    }
}