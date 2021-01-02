using RestApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Services
{
    public class ShopService
    {
        private List<Item> Items = new List<Item>();
        private int number = 0;
        public List<Item> GetAll()
        {
            return Items;
        }
        public void AddItem(Item item)
        {
            number += 1;

            item.Id = number;
            Items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            foreach (var value in Items)
            {
                if (value.Id == item.Id)
                {
                    value.Name = item.Name;
                    value.About = item.About;
                    value.Produced = item.Produced;
                }
            }
        }

        public Item Get(int id)
        {
            Item getItem = null;
            foreach (var value in Items)
            {
                if (value.Id == id)
                {
                    getItem = value;
                }
            }
            return getItem;
        }

        public void DeleteItem(int id)
        {
            Items = Items.Where(i => i.Id != id).ToList();
        }
    }
}
