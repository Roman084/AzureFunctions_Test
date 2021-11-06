using System;

namespace FunctionApp.Data.Dtos.Customer
{
    public class CustomerDto
    {
        
    }

    public class RegisterCustomerDto
    {
        public Guid Id { get; set; } = new Guid();
        public string Company_name { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
    }
}