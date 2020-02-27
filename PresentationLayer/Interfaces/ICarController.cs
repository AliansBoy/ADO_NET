using PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Interfaces
{
    public interface ICarController
    {
        IEnumerable<CarViewModel> GetCars();
        bool Delete(int id);
        bool Create(CarViewModel car);
        bool Update(CarViewModel car);
    }
}
