using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusibessLogicLayer.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public IEnumerable<DetailModel> Details { get; set; }
    }
}
