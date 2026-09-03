using PairProgramming_VibekeAutoshop.Models;

namespace PairProgramming_VibekeAutoshop.Repositories;

public interface ICarRepository
{
    void AddCar(Car car);
    Car? GetCar(int id);
    Car? GetCarByRegistrationNumber(string registrationNumber);
    List<Car> GetAllCars();
    List<Car> GetAvailableCars();
    bool RemoveCar(int id);
    int GetCarCount();
    List<Car> GetCarsByBrand(string brand);
}
