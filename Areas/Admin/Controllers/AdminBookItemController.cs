using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.APIs;
using OnlineBookStore.Business_Layer;
using OnlineBookStore.Helpers;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;
using OnlineBookStore.ViewModels;

namespace OnlineBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class AdminBookItemController : Controller
    {

        private IBookItemServices bookItemServices{get; set;}
        private IBookCategoryServices bookCategoryServices { get; set;}

        private ImagesUploaderHelper _helper = new ImagesUploaderHelper();



        public AdminBookItemController(IBookItemServices bookItemServices, IBookCategoryServices bookCategoryServices)
        {
            this.bookItemServices = bookItemServices;
            this.bookCategoryServices = bookCategoryServices;

        }

        public IActionResult BookItemsList()
        {
        
            List<BookItem> bookItemsList = bookItemServices.GetBookItemsList().ToList();

            return View(bookItemsList);
        }

        public IActionResult AddBookItem()
        {
    
            BookItemAndBookCategoriesViewModel vm = new BookItemAndBookCategoriesViewModel()
            {
                bookItem = new BookItem() { bookItemId=0},
                bookCategories = bookCategoryServices.GetBookCategoriesList().ToList()
            };

            return View(vm);

        }

        public IActionResult EditBookItem(int id)
        {


            BookItemAndBookCategoriesViewModel vm = new BookItemAndBookCategoriesViewModel()
            {
                bookItem = bookItemServices.GetBookItemById(id),
                bookCategories = bookCategoryServices.GetBookCategoriesList().ToList()
            };

            return View("AddBookItem", vm);

        }

        public IActionResult DeleteBookItem(int id)
        {

            var image = bookItemServices.GetBookItemById(id).bookItemImageName;

            if (image != null)
                _helper.DeleteImage(@"wwwRoot\UploadedFiles\Images\BookItemsImages\", image);

            bookItemServices.DeleteBookItem(id);
            return RedirectToAction("BookItemsList");

        }


        [HttpPost]
        public async Task<IActionResult> SaveBookItem(BookItem bookItem, List<IFormFile> Files)
        {

            if (ModelState.IsValid) {

               
            foreach (var file in Files)
            {

                if (file.Length > 0 && file!=null)
                {
                        if (bookItem.bookItemImageName != null)
                        {
                            _helper.DeleteImage(@"wwwRoot\UploadedFiles\Images\BookItemsImages\", bookItem.bookItemImageName);
                        }

                        var imageName = await _helper.UploadImage(file, @"wwwRoot\UploadedFiles\Images\BookItemsImages\");
                        bookItem.bookItemImageName = imageName;

                }
            }

                //Saving adding or editing Data to the DB 
                if (bookItem.bookItemId != 0)
                    bookItemServices.EditBookItemData(bookItem);
                else
                    bookItemServices.AddBookItem(bookItem);

            return RedirectToAction("BookItemsList");

            }

            else
            {
                var vm = new BookItemAndBookCategoriesViewModel()
                {
                    bookItem = bookItem,
                    bookCategories = bookCategoryServices.GetBookCategoriesList().ToList()
                };
                return View("AddBookItem",vm);
            }


        }

        


    }
}
