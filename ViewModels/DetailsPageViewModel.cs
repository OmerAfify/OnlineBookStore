using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.ViewModels
{
    public class DetailsPageViewModel
    {
        public BookItem bookItem { get; set; }
        public List<BookItem> relatedBookItems { get; set; }
    }
}
