using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class BookCategory
    {
        public int bookCategoryId { get; set; }
        public string bookCategoryName { get; set; }
        public virtual List<BookItem> bookItems { get; set; }
    }
}
