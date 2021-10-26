using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GridSystem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public decimal  Price  { get; set; }
        public int Sales { get; set; }
        public int Cat { get; set; }
        public int SubCat { get; set; }
    }
}
