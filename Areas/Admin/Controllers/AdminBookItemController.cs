using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Business_Layer;
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

            // ViewBag.bookCategoriesList = bookItemService.GetBookCategoriesList().ToList();
            
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

            bookItemServices.DeleteBookItem(id);
            return RedirectToAction("BookItemsList");

        }


        [HttpPost]
        public async Task<IActionResult> SaveBookItem(BookItem bookItem, List<IFormFile> Files)
        {

            if (ModelState.IsValid) {

                //Image raising
          
               
            foreach (var file in Files)
            {
                if (file.Length > 0)
                {
                    string ImageName = Guid.NewGuid().ToString() + ".jpg";
                    var filepath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwRoot\UploadedFiles\\Images\BookItemsImages", ImageName);
               
                    using (var stream = System.IO.File.Create(filepath))
                    {
                        await file.CopyToAsync(stream);
                    }
                    bookItem.bookItemImageName = ImageName;
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
