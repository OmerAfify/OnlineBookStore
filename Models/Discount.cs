using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class Discount
    {
        public int discountId { get; set; }
        public string discountName { get; set; }
        public decimal discountPercent { get; set; }
        public DateTime discountStartingDate { get; set; }
        public DateTime discountEndingDate { get; set; }
        public int bookItemId { get; set; }
        public virtual BookItem bookItem { get; set; }
    }
}
