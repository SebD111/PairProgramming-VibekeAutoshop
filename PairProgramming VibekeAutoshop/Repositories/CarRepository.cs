using PairProgramming_VibekeAutoshop.Models;

namespace PairProgramming_VibekeAutoshop.Repositories;

public class CarRepository : ICarRepository
{
    private readonly List<Car> _cars = new();
    private int _nextId = 1;

    public CarRepository()
    {
        SeedData();
    }

    public void AddCar(Car car)
    {
        if (car == null) return;

        car.Id = _nextId++;
        _cars.Add(car);
    }

    public Car? GetCar(int id) => _cars.FirstOrDefault(c => c.Id == id);

    public Car? GetCarByRegistrationNumber(string registrationNumber) =>
        _cars.FirstOrDefault(c => c.RegistrationNumber.Equals(registrationNumber, StringComparison.OrdinalIgnoreCase));

    public List<Car> GetAllCars() => new(_cars);

    public List<Car> GetAvailableCars() => _cars.Where(c => c.IsAvailable).ToList();

    public bool RemoveCar(int id)
    {
        var car = GetCar(id);
        if (car == null) return false;

        return _cars.Remove(car);
    }

    public int GetCarCount() => _cars.Count;

    public List<Car> GetCarsByBrand(string brand) =>
        _cars.Where(c => c.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();

    private void SeedData()
    {
        AddCar(new Car { RegistrationNumber = "AB12345", Brand = "Audi", Model = "A4", Year = 2021, Mileage = 32000, Price = 289000m, RentalPricePerDay = 599m, IsForSale = true, IsForRent = true });
        AddCar(new Car { RegistrationNumber = "CD67890", Brand = "Tesla", Model = "Model 3", Year = 2023, Mileage = 8000, Price = 399000m, RentalPricePerDay = 799m, IsForSale = true, IsForRent = true });
        AddCar(new Car { RegistrationNumber = "EF11223", Brand = "Volkswagen", Model = "Golf", Year = 2019, Mileage = 65000, Price = 149000m, IsForSale = true, IsForRent = false });
        AddCar(new Car { RegistrationNumber = "GH44556", Brand = "BMW", Model = "M3", Year = 2020, Mileage = 41000, Price = 459000m, RentalPricePerDay = 999m, IsForSale = false, IsForRent = true });
    }
}
