using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class OrderDetails
    {

        public int orderDetailsId { get; set; }

        public int orderId { get; set; }
        public virtual Order order { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneNumber { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public int departmentNo { get; set; }
        public string payementType { get; set; }
        public decimal totalPrice { get; set; }

        public decimal totalQuantity { get; set; }
        public virtual List<OrderedItem> orderedItems{ get; set; }


    }
}
