using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
        public Campaign(int Id, string Name, int Discount) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Discount = Discount;
        }
    }
}
