using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSale.DAL.Entities
{
    class Payment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CarId")]
        public int CarId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public bool Paid { get; set; }
    }
}
