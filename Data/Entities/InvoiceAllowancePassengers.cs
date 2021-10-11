using System;

namespace FunctionApp.Data.Entities
{
    public class InvoiceAllowancePassengers
    {
        public Guid Id { get; set; }
        public string Passenger { get; set; }
        
        public Guid Allowance_id { get; set; }
    }
}