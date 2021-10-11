using System;

namespace FunctionApp.Data.Entities
{
    public class InvoiceItems
    {
        public Guid Id { get; set; }
        public int Invoice_item_id { get; set; }
        public string Debt_invoice_number { get; set; }
        public decimal Interest { get; set; }
        public decimal Interest_percent { get; set; }
        public decimal Amount { get; set; }
    }
}