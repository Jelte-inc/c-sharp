namespace CheraasjeEpp.Models.Entities
{
    public class Car
    {
        public int Id { get; set; }
        required public string Brand { get; set; }
        required public string Model { get; set; }
        required public string Color { get; set; }
        required public int AmountOfDoors { get; set; }
        required public decimal Price { get; set; }
        public List<string>? ImagePaths { get; set; }
        required public int BuildYear { get; set; }
        required public decimal Mileage { get; set; }
        required public string TransmissionType { get; set; }
        required public string? LicensePlate { get; set; }
        public string Name() => $"{Brand} {Model}";
        public bool HasImages() => ImagePaths != null && ImagePaths.Count > 0;
        public void UpdatePice(decimal nieuwePrijs) => Price = nieuwePrijs;
        public override string ToString() => Name();
    }
}
