using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.SuperMarket.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public ProductCategory Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
