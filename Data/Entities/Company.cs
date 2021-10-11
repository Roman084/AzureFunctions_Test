using System;
using System.Collections.Generic;

namespace FunctionApp.Data.Entities
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Company_name { get; set; }
        public string Email{ get; set; }
        public string Account_number { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Zip_code { get; set; }
        public string City { get; set; }
        public decimal Service_payment { get; set; }
        public string Business_id { get; set; }
        public string Password { get; set; }
        public string Comments { get; set; }
        public string Payment_control { get; set; }
        public string Bank_name{ get; set; }
        public string User_type { get; set; }
        public string User_contact_name { get; set; }
        public int Seller_num { get; set; }
        
        public Document Document { get; set; }
        public ICollection<Customer> Customer { get; set; }
    }
}