using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;
using OnlineBookStore.ViewModels;

namespace OnlineBookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<BookItem> bookItemsList;

        private ISliderServices slidersService { get; }
        private IBookItemServices booksItemsService { get; }
        private IBookCategoryServices bookscategoriesService { get; }

        public HomeController(ISliderServices sliderServices, IBookItemServices bookItemsServices, IBookCategoryServices bookCategoriesServices)
        {
            this.slidersService = sliderServices;
            this.booksItemsService = bookItemsServices;
            this.bookscategoriesService = bookCategoriesServices;

        }

        public IActionResult Index()
        {
            HomePageViewModel vm = new HomePageViewModel()
            {
                slidersList = slidersService.GetSlidersList().ToList(),
                bookItemsList = booksItemsService.GetBookItemsList().ToList(),
                popularBookItemsList = booksItemsService.GetBookItemsList().Take(5).ToList(),
                CategoriesList = bookscategoriesService.GetBookCategoriesList().ToList(),
                upSaleBookItemsList = booksItemsService.GetUpSalesBookItemsList().ToList()


            };
            return View(vm);
        }
    }
}
