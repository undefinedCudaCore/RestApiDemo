using Microsoft.AspNetCore.Mvc;
using RestApiDemo.Models;
using RestApiDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitController : ControllerBase
    {
        private readonly FruitService _fruitService;

        public FruitController(FruitService fruitService)
        {
            _fruitService = fruitService;
        }

        [HttpGet]
        public List<Item> GetAll()
        {
            return _fruitService.GetAll();
        }

        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _fruitService.Get(id);
        }

        [HttpPost]
        public void AddItem(Item item)
        {
            _fruitService.AddItem(item);
        }

        [HttpPut]
        public void UpdateItem(Item item)
        {
            _fruitService.UpdateItem(item);
        }

        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
            _fruitService.DeleteItem(id);
        }
    }
}
