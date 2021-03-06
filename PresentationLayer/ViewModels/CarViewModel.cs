﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.ViewModels
{
    public class CarViewModel
    {
        public string Manufacturer { get; set; }
        public IEnumerable<DetailViewModel> Details { get; set; }
    }
}
