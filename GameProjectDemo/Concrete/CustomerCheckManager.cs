using GameProjectDemo.Abstract;
using GameProjectDemo.Adapters;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        //private ICustomerCheckService _customerCheckService;
        private CustomerCheckManager()//the constructor to prevent other classes creating instances
        {

        }
        public CustomerCheckManager(ICustomerCheckService customerCheckService) 
        { 

        }
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
