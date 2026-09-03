namespace PairProgramming_VibekeAutoshop.Models;

public class Car
{
    public int Id { get; set; }
    public string RegistrationNumber { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public int Mileage { get; set; }
    public decimal Price { get; set; }
    public decimal? RentalPricePerDay { get; set; }
    public bool IsForSale { get; set; } = true;
    public bool IsForRent { get; set; }
    public bool IsAvailable { get; set; } = true;

    public int GetAge() => DateTime.Now.Year - Year;

    public bool IsVintage() => GetAge() > 25;

    public override string ToString() => $"{Year} {Brand} {Model}";
}
