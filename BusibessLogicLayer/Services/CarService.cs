using BusibessLogicLayer.Interfaces;
using BusibessLogicLayer.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusibessLogicLayer.Services
{
    public class CarService : ICarService
    {
        private ICarRepositorie carRepository;
        private IDetailService detailService;
        public CarService()
        {
            carRepository = new CarRepositorie();
            detailService = new DetailService();
        }
        public bool Create(CarModel car)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarModel> GetCars()
        {
            var details = detailService.GetDetails();

            var carCollection = carRepository.GetCars().Select(car => new CarModel()
            {
                Id = car.Id,
                Manufacturer = car.Manufacturer,
                Details = details.Where(x => x.CarId == car.Id)
            });

            return carCollection;
        }

        public bool Update(CarModel car)
        {
            throw new NotImplementedException();
        }
    }
}
