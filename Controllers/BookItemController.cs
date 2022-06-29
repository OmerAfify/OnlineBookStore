using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Interfaces;
using OnlineBookStore.ViewModels;

namespace OnlineBookStore.Controllers
{
    public class BookItemController : Controller
    {
        private IBookItemServices bookItemServices { get; set; }
        public BookItemController(IBookItemServices bookItemServices)
        {
            this.bookItemServices = bookItemServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ItemDetails(int id)
        {
            DetailsPageViewModel vm = new DetailsPageViewModel();

            vm.bookItem = bookItemServices.GetBookItemById(id);
            vm.relatedBookItems = bookItemServices.GetRelatedBookItemsList(vm.bookItem).ToList();
            
            return View(vm);
        }

        public IActionResult BookItemList()
        {
        
            return View();
        }


    }
}
