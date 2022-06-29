using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class CartItem
    {
        public int bookItemId { get; set; }
        public BookItem bookItem { get; set; }
        public int itemQuantity { get; set; }
        public decimal  totalItemPrice { get; set; }
    }
}
