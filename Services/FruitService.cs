using FruitStoreWeb.IServices;
using FruitStoreWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStoreWeb.Services
{
    public class FruitService:IFruitService
    {

        FruitStoreDBContext dbContext;
        //private IEnumerable<Fruit> fruit;

        public FruitService(FruitStoreDBContext _db)
        {

            dBContext = _db;
        }

        public IEnumerable<Fruit> GetFruit()
        {
            var fruit = dbContext.Fruit.ToList();

            return fruit;
        }


        public Fruit AddFruit(Fruit fruit)
        {
            if (fruit != null)
            {
                dbContext.Fruit.Add(fruit);
                dbContext.SaveChanges();
                return fruit;
            }
            return null;
        }

        public Fruit UpdateFruit(Fruit fruit)
        {
            dbContext.Entry(fruit).State = EntityState.Modified;
            dbContext.SaveChanges();
            return fruit;
        }

        public Fruit DeleteFruit(int id)
        {
            var fruit = dbContext.Fruit.FirstOrDefault(x => x.Id == id);
            dbContext.Entry(fruit).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return fruit;
        }

        public Fruit GetFruitById(int id)
        {
            var fruit = dbContext.Fruit.FirstOrDefault(x => x.Id == id);
            return fruit;
        }
    }
}
