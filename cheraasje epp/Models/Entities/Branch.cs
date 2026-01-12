namespace cheraasje_epp.Models.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Adress { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public int Owner { get; set; }
        public List<Car> Cars { get; set; } = new();

        public decimal AveragePrice =>
            Cars.Any() ? Cars.Average(a => a.Price) : 0m;

        public decimal TotalValue =>
            Cars.Sum(a => a.Price);


        public override string ToString() => $"{Name} ({Location})";
    }
}
