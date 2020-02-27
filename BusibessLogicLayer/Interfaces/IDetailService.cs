using BusibessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusibessLogicLayer.Interfaces
{
    public interface IDetailService
    {
        IEnumerable<DetailModel> GetDetails();
        bool Delete(int id);
        bool Create(DetailModel detail);
        bool Update(DetailModel detail);
    }
}
