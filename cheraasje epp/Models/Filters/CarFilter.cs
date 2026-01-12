namespace CheraasjeEpp.Models.Filters
{
    public class CarFilter
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public int? AmountOfDoors { get; set; }
        public PriceRange? PriceRange { get; set; }
    }

}
