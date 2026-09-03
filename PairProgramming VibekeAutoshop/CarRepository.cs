using System;
using System.Collections.Generic;
using System.Linq;

namespace PairProgramming_VibekeAutoshop
{
    public class CarRepository
    {
        private List<Car> cars = new List<Car>();
        private int nextId = 1;

        public void AddCar(Car car)
        {
            if (car != null)
            {
                cars.Add(car);
                nextId++;
            }
        }

        public Car GetCar(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                return cars[index];
            }
            return null;
        }

        public List<Car> GetAllCars()
        {
            return new List<Car>(cars);
        }

        public bool RemoveCar(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                cars.RemoveAt(index);
                return true;
            }
            return false;
        }

        public int GetCarCount()
        {
            return cars.Count;
        }

        public List<Car> GetCarsByBrand(string brand)
        {
            return cars.Where(c => c.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void ClearAll()
        {
            cars.Clear();
        }
    }
}
