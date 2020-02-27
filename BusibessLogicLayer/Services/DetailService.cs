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
    public class DetailService : IDetailService
    {
        private IDetailRepositorie detailRepository;
        private ICarRepositorie carRepositorie;
        public DetailService()
        {
            detailRepository = new DetailRepositorie();
            carRepositorie = new CarRepositorie();
        }
        public bool Create(DetailModel detail)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetailModel> GetDetails()
        {
            var cars = carRepositorie.GetCars();
            var details = detailRepository.GetDetails().Select(d => new DetailModel()
            {
                Id = d.Id,
                Name = d.Name,
                Price = d.Price,
                CarId = d.CarId
            });
            return details;
        }

        public bool Update(DetailModel detail)
        {
            throw new NotImplementedException();
        }
    }
}
