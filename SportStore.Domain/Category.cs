using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
