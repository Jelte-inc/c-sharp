using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheraasje_epp.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int AmountOfDoors { get; set; }
            public double Price { get; set; }
            public string Image { get; set; }
        public string Name() => $"{Brand} {Model}";
        public bool HasImage() => !string.IsNullOrEmpty(Image);
        public void UpdatePice(double nieuwePrijs) => Price = nieuwePrijs;
        public string ShowPrice() => Price.ToString("F2");
        public override string ToString() => Name();
    }
}
