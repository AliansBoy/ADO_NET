using BusibessLogicLayer.Interfaces;
using BusibessLogicLayer.Services;
using PresentationLayer.Interfaces;
using PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class CarController : ICarController
    {
        private ICarService carService;
        public CarController()
        {
            carService = new CarService();

        }
        public bool Create(CarViewModel car)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarViewModel> GetCars()
        {
            var carCollection = carService.GetCars().Select(car => new CarViewModel()
            {
                Manufacturer = car.Manufacturer,
                Details = car.Details.Select(det => new DetailViewModel()
                {
                    Name = det.Name,
                    Price = det.Price
                })

            });
            return carCollection; ;
        }

        public bool Update(CarViewModel car)
        {
            throw new NotImplementedException();
        }
    }
}
