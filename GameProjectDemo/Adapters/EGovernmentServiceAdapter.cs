using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Adapters
{
    public class EGovernmentServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if (customer.FirstName == "Muhammed Murat")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
