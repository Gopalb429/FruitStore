using FruitStoreWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FruitStoreWeb.IServices
{
    public interface IFruitService
    {
        IEnumerable<Fruit> GetFruit();
        Fruit GetFruitById(int id);
        Fruit AddFruit(Fruit fruit);
        Fruit UpdateFruit(Fruit fruit);
        Fruit DeleteFruit(int id);

    }
}
