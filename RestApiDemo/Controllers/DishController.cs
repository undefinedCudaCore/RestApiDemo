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
    public class DishController : ControllerBase
    {
        private readonly DishService _dishService;

        public DishController(DishService dishService)
        {
            _dishService = dishService;
        }

        [HttpGet]
        public List<Item> GetAll()
        {
            return _dishService.GetAll();
        }

        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _dishService.Get(id);
        }

        [HttpPost]
        public void AddItem(Item item)
        {
            _dishService.AddItem(item);
        }

        [HttpPut]
        public void UpdateItem(Item item)
        {
            _dishService.UpdateItem(item);
        }

        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
            _dishService.DeleteItem(id);
        }
    }
}
