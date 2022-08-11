using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class BookCategory
    {
        [Required]
        public int bookCategoryId { get; set; }
        [Required]
        public string bookCategoryName { get; set; }
        public string bookCategoryDescription { get; set; }
        public virtual List<BookItem> bookItems { get; set; }
    }
}
