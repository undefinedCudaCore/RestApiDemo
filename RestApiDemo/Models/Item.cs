using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  About About { get; set; }
        public string Produced { get; set; }
        public DateTime? LastModified { get; set; }

    }
}
