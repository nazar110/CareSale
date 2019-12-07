using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSale.DAL.Entities
{
    class CarModel
    {
        [Key]
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public string Features { get; set; }
        public uint Price { get; set; }
    }
}
