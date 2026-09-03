using PairProgramming_VibekeAutoshop.Models;

namespace PairProgramming_VibekeAutoshop.Repositories;

public class SaleRepository : ISaleRepository
{
    private readonly List<Sale> _sales = new();
    private int _nextId = 1;

    public void AddSale(Sale sale)
    {
        if (sale == null) return;

        sale.Id = _nextId++;
        _sales.Add(sale);
    }

    public List<Sale> GetAllSales() => new(_sales);
}
