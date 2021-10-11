using System;
using System.Collections.Generic;

namespace FunctionApp.Data.Entities
{
    public class Salary
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Status { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string StatusPaid { get; set; }
        public string StatusProcessing { get; set; }
        public decimal Gross_salary { get; set; }
        public decimal Net_salary { get; set; }
        public decimal Service_cost { get; set; }
        public decimal Expenses_cost { get; set; }
        public decimal Reimbursment_cost { get; set; }
        public decimal Take_home_pay { get; set; }
        public decimal Tax_cost { get; set; }
        public decimal Yel_cost { get; set; }
        public decimal Accidental_insurance { get; set; }
        public decimal Social_contribution { get; set; }
        public decimal SumWithoutTax { get; set; }
        public decimal Palkka { get; set; }
        public decimal Deductions_sum { get; set; }
        
        public ICollection<Invoice> Invoices { get; set; }
    }
}