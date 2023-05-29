using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Entities
{
    public class Game : Product
    {
        public string Publisher { get; set; }

        public Game(int Id, int CategoryId, string name, string Publisher) : base(Id, CategoryId, name)
        {
            this.Publisher = Publisher;
        }

        
    }
}
