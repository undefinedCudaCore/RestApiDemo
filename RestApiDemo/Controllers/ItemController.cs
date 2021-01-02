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
    public class ItemController : ControllerBase
    {
        private readonly ShopService _shopService;

        public ItemController(ShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpGet]
        public List<Item> GetAll()
        {
            return _shopService.GetAll();
        }

        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _shopService.Get(id);
        }

        [HttpPost]
        public void AddItem(Item item)
        {
            _shopService.AddItem(item);
        }

        [HttpPut]
        public void UpdateItem(Item item)
        {
            _shopService.UpdateItem(item);
        }

        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
            _shopService.DeleteItem(id);
        }
    }

}
