using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class BookItem
    {
        [Required]
        public int bookItemId { get; set; }
     
        [Required (ErrorMessage = "please enter Book items name")]
        public string bookItemName { get; set; }


        [Required(ErrorMessage = "please enter sales Price")]
        [DataType(DataType.Currency)]
        public decimal? salesPrice { get; set; }


        [Required(ErrorMessage = "please enter purchase price")]
        [DataType(DataType.Currency)]
        public decimal? purchasePrice { get; set; }

        public string bookItemImageName { get; set; }

        public DateTime creationalDate { get; set; }


        [Required(ErrorMessage = "please enter a Category")]
        public int bookCategoryId { get; set; }
        public virtual BookCategory bookCategory { get; set; }

        public List<Discount> discountList { get; set; }
        public List<BookItemImage> bookItemImageList { get; set; }
     



    }
}
