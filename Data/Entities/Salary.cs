using System;
using System.Collections.Generic;

namespace FunctionApp.Data.Entities
{
    public class Salary
    {
        public Guid Id { get; set; }
        public string firstname { get; set; }
        public string status { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string statusPaid { get; set; }
        public string StatusProcessing { get; set; }
        public decimal gross_salary { get; set; }
        public decimal net_salary { get; set; }
        public decimal service_cost { get; set; }
        public decimal expenses_cost { get; set; }
        public decimal reimbursment_cost { get; set; }
        public decimal take_home_pay { get; set; }
        public decimal tax_cost { get; set; }
        public decimal yel_cost { get; set; }
        public decimal accidental_insurance { get; set; }
        public decimal social_contribution { get; set; }
        public decimal sumWithoutTax { get; set; }
        public decimal palkka { get; set; }
        public decimal deductions_sum { get; set; }
    }
}