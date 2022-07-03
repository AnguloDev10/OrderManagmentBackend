using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Entities
{
    public class Product : EntityBase
    {
        public int unitPrice { get; set; }

        public int unitStock { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }
    }
}
