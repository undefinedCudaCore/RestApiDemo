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
    public class VegieController : ControllerBase
    {
        private readonly VegieService _vegieService;

        public VegieController(VegieService vegieservice)
        {
            _vegieService = vegieservice;
        }

        [HttpGet]
        public List<Item> GetAll()
        {
            return _vegieService.GetAll();
        }

        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _vegieService.Get(id);
        }

        [HttpPost]
        public void AddItem(Item item)
        {
            _vegieService.AddItem(item);
        }

        [HttpPut]
        public void UpdateItem(Item item)
        {
            _vegieService.UpdateItem(item);
        }

        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
            _vegieService.DeleteItem(id);
        }
    }
}
