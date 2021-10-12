using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStoreWeb.Models
{
    public partial class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Quantity { get; set; }

        public decimal? Price { get; set; }

    }
}
