using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class OrderDetails
    {

        public int orderDetailsId { get; set; }

        public int orderId { get; set; }
        public virtual Order order { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        public int phoneNumber { get; set; }

        [Required] 
        public string country { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public int departmentNo { get; set; }

        [Required]
        public string payementType { get; set; }
        public decimal totalPrice { get; set; }
        public decimal totalQuantity { get; set; }
        public virtual List<OrderedItem> orderedItems{ get; set; }


    }
}
