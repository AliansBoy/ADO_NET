using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ICarRepositorie 
    {
        IEnumerable<Car> GetCars();
        bool Delete(int id);
        bool Create(Car car);
        bool Update(Car car);
    }
}
