using PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Interfaces
{
    public interface IDetailController
    {
        IEnumerable<DetailViewModel> GetDetails();
        bool Delete(int id);
        bool Create(DetailViewModel detail);
        bool Update(DetailViewModel detail);
    }
}
