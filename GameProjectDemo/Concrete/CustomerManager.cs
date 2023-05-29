using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class CustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Customer " + customer.FirstName + " added successfully");
            }
            else 
            { 
                Console.WriteLine("Customer " + customer.FirstName + " couldn't add because of fail validation"); 
            }
        }
        public void Remove(Customer customer)
        {
            Console.WriteLine("Customer " + customer.FirstName + " removed successfully");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Customer " + customer.FirstName + " updated successfully");
        }
    }
}
