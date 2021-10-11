using System;
using System.Collections.Generic;

namespace FunctionApp.Data.Entities
{
    public class Allowances
    {
        public Guid Id { get; set; }
        public string Invoice_id { get; set; }
        public string Destination { get; set; }
        public string Country { get; set; }
        public DateTime Start_date { get; set; }
        public TimeSpan Start_time { get; set; }
        public TimeSpan End_time { get; set; }
        public DateTime End_date { get; set; }
        public bool? Mileage_allowance { get; set; }
        public bool? Day_allowance { get; set; }
        public decimal Full_time_allowance { get; set; }
        public decimal Part_time_allowance { get; set; }
        public decimal Meal_allowance { get; set; }
        public decimal Distance { get; set; }
        public int Vehicle_type_id { get; set; }
        public string License_plate {get;set;}
        public int Passenger_count { get; set; }
        public int Additional_vehicle_cost_id { get; set; }
        public bool? Forest_trail { get; set; }
        public bool? Heavy_load { get; set; }
        public bool? Working_dog { get; set; }
        public string Vehicle_type { get; set; }
        
        public ICollection<InvoiceAllowanceRouteItems> AllowanceInputRow { get; set; }
        public ICollection<InvoiceAllowancePassengers> AllowancePassenger { get; set; }
    }
}