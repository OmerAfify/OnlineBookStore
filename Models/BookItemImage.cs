using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class BookItemImage
    {
        public int bookItemImageId { get; set; }
        public int bookImageName { get; set; }

        public int bookItemId { get; set; }
        public BookItem bookItem { get; set; }
    }
}
