using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSale.DAL.Entities
{
    class CarBrand
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ModelId")]
        public int ModelId {get; set;}
        public string BrandName { get; set; }
        public string CountryOfOrigin { get; set; }
    }
}
