using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.DTOs
{
    public class BookItemDto
    {

        public int bookItemId { get; set; }
        public string bookItemName { get; set; }

        public decimal salesPrice { get; set; }

        public decimal purchasePrice { get; set; }

        public string bookItemImageName { get; set; }

        public string bookCategoryName { get; set; }

    }
}
