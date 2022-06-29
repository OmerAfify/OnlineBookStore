using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.ViewModels
{
    public class HomePageViewModel
    {
        public List<Slider> slidersList { get; set; }
        public List<BookItem> bookItemsList { get; set; }
        public List<BookItem> popularBookItemsList { get; set; }
        public List<BookItem> upSaleBookItemsList { get; set; }
        public List<BookCategory> CategoriesList { get; set; }

        
    }
}
