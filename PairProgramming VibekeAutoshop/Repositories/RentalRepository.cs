using PairProgramming_VibekeAutoshop.Models;

namespace PairProgramming_VibekeAutoshop.Repositories;

public class RentalRepository : IRentalRepository
{
    private readonly List<Rental> _rentals = new();
    private int _nextId = 1;

    public void AddRental(Rental rental)
    {
        if (rental == null) return;

        rental.Id = _nextId++;
        _rentals.Add(rental);
    }

    public List<Rental> GetAllRentals() => new(_rentals);
}
