using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSale.DAL.Entities
{
    class UserAddress
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string City { get; set; }
        public string CityStreet { get; set; }
        public string StreetNumber { get; set; }
    }
}
