using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Entities
{
    public class OrderDetail : EntityBase
    {
       public DateTime OrderDate { get; set; }
       public int CustomerId { get; set; } 
       public Customer Customer { get; set; }

       public int OrderId { get; set; }
       public Order Order { get; set; }

       public int ProductId { get; set; }
       public Product Product { get; set; }

    }
}
