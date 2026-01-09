namespace cheraasje_epp.Models.Entities
{
    public class Car
    {
        required public string Brand { get; set; }
        required public string Model { get; set; }
        required public string Color { get; set; }
        required public int AmountOfDoors { get; set; }
        required public decimal Price { get; set; }
        public string? Image { get; set; }
        required public int BuildYear { get; set; }
        required public decimal Mileage { get; set; }
        required public string TransmissionType { get; set; }
        public string Name() => $"{Brand} {Model}";
        public bool HasImage() => !string.IsNullOrEmpty(Image);
        public void UpdatePice(decimal nieuwePrijs) => Price = nieuwePrijs;
        public override string ToString() => Name();
    }
}
