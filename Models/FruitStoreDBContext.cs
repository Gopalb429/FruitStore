using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStoreWeb.Models
{
    public partial class FruitStoreDBContext :DbContext
    {
        public FruitStoreDBContext()
        {


        }

        public FruitStoreDBContext(DbContextOptions<FruitStoreDBContext> options):base(options)
        {

        }

        public virtual Dbset<Fruit> Fruit { get; set; }

    }
}
