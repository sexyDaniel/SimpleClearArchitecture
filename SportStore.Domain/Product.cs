using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string PhotoLink { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
