namespace PairProgramming_VibekeAutoshop.Models;

public class Rental
{
    public int Id { get; set; }
    public string RegistrationNumber { get; set; } = string.Empty;
    public string RenterName { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.Now;
    public int RentalDays { get; set; }
    public decimal RentalPrice { get; set; }

    public DateTime EndDate => StartDate.AddDays(RentalDays);
}
