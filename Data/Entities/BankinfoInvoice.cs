using System;

namespace FunctionApp.Data.Entities
{
    public class BankInfoInvoice
    {
        public Guid Id { get; set; }
        public int invoice_id { get; set; }
        public DateTime credit_date_time { get; set; }
        public string groupMsgId { get; set; }
        public string paymentId { get; set; }
        public string tran_end_end_id { get; set; }
        public decimal invoice_sum { get; set; }
    }
}