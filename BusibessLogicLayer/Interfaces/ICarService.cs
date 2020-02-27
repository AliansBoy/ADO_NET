using BusibessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusibessLogicLayer.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetCars();
        bool Delete(int id);
        bool Create(CarModel car);
        bool Update(CarModel car);
    }
}
