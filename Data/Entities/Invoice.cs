using System;

namespace FunctionApp.Data.Entities
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public int ActualDebtInvoiceId { get; set; }
        public string Job_title { get; set; }
        public string Referencenumber { get; set; }
        public DateTime Billing_date { get; set; }
        public DateTime Debt_billing_date { get; set; }
        public DateTime Debt_due_date { get; set; }
        public DateTime Due_date { get; set; }
        public DateTime Installment_due_date{ get; set; }
        public decimal Sum_with_interest { get; set; }
        public int Status { get; set; }
        public DateTime  Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public int InvoicePaid { get; set; }
        public int Invoice_rejected { get; set; }
        public string Debt_invoice_number { get; set; }
        public decimal Interest { get; set; }
        public decimal Interest_percent { get; set; }
        public decimal Amount { get; set; }
        public string Invoice_justification { get; set; }
        public int Remindersent { get; set; }
        public bool IsInstall { get; set; }
        public int Noofinstall { get; set; }
        public string Pdf_display_username { get; set; }
        public int? Search_invoice_id { get; set; }
        public DateTime Overdue { get; set; }
        
        public Guid Customer_id { get; set; }
        public Customer CustomerType { get; set; }
    }
}