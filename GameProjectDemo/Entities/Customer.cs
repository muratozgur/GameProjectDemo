using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public Customer(int Id, string NationalityId, string FirstName, string LastName, int BirthYear)
        {
            this.Id = Id;
            this.NationalityId = NationalityId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthYear = BirthYear;
        }
    }
}
