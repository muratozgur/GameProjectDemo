using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("The campaign " + campaign.Name + " has been added");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("The campaign " + campaign.Name + " has been removed");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("The campaign " + campaign.Name + " has been updated");
        }
    }
}
