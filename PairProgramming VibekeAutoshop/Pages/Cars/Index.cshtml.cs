using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PairProgramming_VibekeAutoshop.Models;
using PairProgramming_VibekeAutoshop.Repositories;

namespace PairProgramming_VibekeAutoshop.Pages.Cars;

public class IndexModel : PageModel
{
    private readonly ICarRepository _carRepository;

    public IndexModel(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public List<Car> Cars { get; set; } = new();

    public void OnGet()
    {
        Cars = _carRepository.GetAvailableCars();
    }

    // Stub handlers - fuld køb/leje-logik implementeres løbende
    public IActionResult OnPostBuy(int id)
    {
        return RedirectToPage(new { });
    }

    public IActionResult OnPostRent(int id)
    {
        return RedirectToPage(new { });
    }
}
