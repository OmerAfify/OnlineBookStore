using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class OrderedItem
    {
        public int orderDetailsId { get; set; }
        public OrderDetails orderDetails { get; set; }

        public int bookItemId { get; set; }
        public BookItem bookItem { get; set; }
        public int totalItemQuantity { get; set; }
        public decimal totalItemPrice { get; set; }
    }
}
