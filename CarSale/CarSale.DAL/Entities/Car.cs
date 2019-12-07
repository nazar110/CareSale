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
        [ForeignKey("BrandId")]
        public int BrandId { get; set; }
        public string Color { get; set; }
    }
}
