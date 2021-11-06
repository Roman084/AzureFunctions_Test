using System;

namespace FunctionApp.Data.Entities
{
    public class InvoiceItems
    {
        public Guid Id { get; set; }
        public int invoice_id { get; set; }
        public string debt_invoice_number { get; set; }
        public decimal interest { get; set; }
        public decimal interest_percent { get; set; }
        public decimal amount { get; set; }
    }
}