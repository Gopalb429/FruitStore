using FruitStoreWeb.IServices;
using FruitStoreWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitStoreWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        private readonly IFruitService fruitService;
        public FruitController(IFruitService fruit)
        {
            fruitService = fruit;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Fruit/GetFruit")]
        public IEnumerable<Fruit> GetFruit()
        {
            return fruitService.GetFruit();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Fruit/AddFruit")]
        public Fruit AddFruit(Fruit fruit)
        {
            return fruitService.AddFruit(fruit);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Fruit/EditFruit")]
        public Fruit EditFruit(Fruit fruit)
        {
            return fruitService.UpdateFruit(fruit);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Fruit/DeleteFruit")]
        public Fruit DeleteFruit(int id)
        {
            return fruitService.DeleteFruit(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Fruit/GetFruitId")]
        public Fruit GetFruitId(int id)
        {
            return fruitService.GetFruitById(id);
        }

    }
}
