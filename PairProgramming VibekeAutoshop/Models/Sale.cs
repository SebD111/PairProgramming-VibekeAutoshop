namespace PairProgramming_VibekeAutoshop.Models;

public class Sale
{
    public int Id { get; set; }
    public string RegistrationNumber { get; set; } = string.Empty;
    public string BuyerName { get; set; } = string.Empty;
    public int MileageAtSale { get; set; }
    public decimal Price { get; set; }
    public DateTime SaleDate { get; set; } = DateTime.Now;
}
