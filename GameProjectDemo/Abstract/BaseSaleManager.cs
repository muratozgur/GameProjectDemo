using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseSaleManager
    {
        public void Sell(Product product, Customer customer, Campaign campaign)
        {
            Console.WriteLine("The product has been successfully sold to " + customer.FirstName
                + ", with " + campaign.Name + " campaign");
        }
    }
}
