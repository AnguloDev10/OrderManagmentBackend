using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Entities
{
    public class Order : EntityBase
    {
        public DateTime OrderDate { get; set; }

        public string ShipCity { get; set; }

        public string Description { get; set; }

        public ICollection<OrderDetail> Details { get; set; }


    }
}
