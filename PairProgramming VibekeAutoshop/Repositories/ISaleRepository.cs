using PairProgramming_VibekeAutoshop.Models;

namespace PairProgramming_VibekeAutoshop.Repositories;

public interface ISaleRepository
{
    void AddSale(Sale sale);
    List<Sale> GetAllSales();
}
