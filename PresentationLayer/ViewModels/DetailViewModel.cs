using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.ViewModels
{
    public class DetailViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int CarId { get; set; }
        public CarViewModel Cars { get; set; }
    }
}
