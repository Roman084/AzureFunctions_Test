using System;

namespace FunctionApp.Data.Entities
{
    public class InvoiceAllowanceRouteItems
    {
        public Guid Id {get;set;}
        public int Allowance_id { get; set; }
        public string Route { get; set; }
    }
}