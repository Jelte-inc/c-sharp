using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheraasje_epp.Models
{
    internal class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string Owner { get; set; }
        public List<Car> Cars { get; set; } = new();

        public double AveragePrice => Cars.Any() ? Cars.Average(a => a.Price) : 0;
        public double TotalValue => Cars.Sum(a => a.Price);

        public override string ToString() => $"{Name} ({Location})";
    }
}
