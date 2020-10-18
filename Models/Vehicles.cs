using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace stock_taking_system.Models
{
    public class Vehicles
    {
        public int ID { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Features { get; set; }     
    }
    
}
