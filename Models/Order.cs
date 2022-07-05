using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public string userId { get; set; }
        public virtual ApplicationIdentiyUser user { get; set; }

        public virtual OrderDetails orderDetails { get; set; }


        public int orderStatusId { get; set; }
        public virtual OrderStatus orderStatus { get; set; }

    }
}
