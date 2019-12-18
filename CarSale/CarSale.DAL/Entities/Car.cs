using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSale.DAL.Entities
{
    class Car
    {
        [Key]
        public int Id { get; set; }
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
