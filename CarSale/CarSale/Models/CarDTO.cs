using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSale.Models
{
    public class CarDTO
    {
        public string ImageUrl { get; set; }
        public string Brandname { get; set; }
        public string Modelname { get; set; }
        public string Color { get; set; }
        public string Features { get; set; }
        public string CountryOfOrigin { get; set; }
        public uint Price { get; set; }
        public string LongDescription { get; set; }
    }
}
