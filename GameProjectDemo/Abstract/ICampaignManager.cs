using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public interface ICampaignManager
    {
        public void Add(Campaign campaign);
        public void Remove(Campaign campaign);
        public void Update(Campaign campaign);
    }
}
