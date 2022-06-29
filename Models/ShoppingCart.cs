using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class ShoppingCart

    {
        public virtual List<CartItem> cartItemList { get; set; }
        public decimal totalCartPrice { get; set; }
        public int totalCartQuantity { get; set; }
    }
}
