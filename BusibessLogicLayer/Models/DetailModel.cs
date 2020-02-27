using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusibessLogicLayer.Models
{
    public class DetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CarId { get; set; }
        public CarModel Cars { get; set; }

    }
}
