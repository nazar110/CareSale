using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSale.Models
{
    public class PaymentDTO
    {
        public string City { get; set; }
        public string CityStreet { get; set; }
        public string StreetNumber { get; set; }
        public CarDTO CarToBuy { get; set; }
        public bool Paid { get; set; }
    }
}
