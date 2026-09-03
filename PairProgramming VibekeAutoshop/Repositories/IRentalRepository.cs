using PairProgramming_VibekeAutoshop.Models;

namespace PairProgramming_VibekeAutoshop.Repositories;

public interface IRentalRepository
{
    void AddRental(Rental rental);
    List<Rental> GetAllRentals();
}
