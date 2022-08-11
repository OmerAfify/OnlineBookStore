using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Helpers;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;

  namespace OnlineBookStore.Areas.Admin.Controllers
   {
     
        [Area("Admin")]
        [Authorize(Roles = "Admin")]
        public class AdminBookCategoryController : Controller
        {

            private IBookCategoryServices bookCategoryServices { get; set; }
            private ImagesUploaderHelper _helper = new ImagesUploaderHelper();


        public AdminBookCategoryController(IBookCategoryServices bookCategoryServices)
            {
                 this.bookCategoryServices = bookCategoryServices;

            }

            public IActionResult BookCategoriesList()
            {

                List<BookCategory> bookCategoriesList = bookCategoryServices.GetBookCategoriesList().ToList();
                return View(bookCategoriesList);

            }

            public IActionResult AddBookCategory()
            {
                return View(new BookCategory());
            }

            public IActionResult UpdateBookCategory(int id)
            {
                if(id!=0 && id != null) {
                    var bookcategory = bookCategoryServices.GetBookCategoryById(id);
                    return View("AddBookCategory",bookcategory);
                }
                else
                {
                    return View("AddBookCategory");
                }

    

            }

            public IActionResult DeleteBookCategory(int id)
            {

                var catItems = bookCategoryServices.GetBookCategoryById(id);

                foreach(var book in catItems.bookItems)
                {
                var bookImage = book.bookItemImageName;
                _helper.DeleteImage(@"wwwRoot\UploadedFiles\Images\BookItemsImages\", bookImage);

                }
                bookCategoryServices.DeleteBookCategory(id);

                return RedirectToAction("BookCategoriesList");

            }


            [HttpPost]
            public IActionResult SaveBookCategory(BookCategory bookCategory)
            {

                if (ModelState.IsValid)
                {

                     if (bookCategory.bookCategoryId != 0)
                        bookCategoryServices.EditBookCategory(bookCategory);
                    else
                        bookCategoryServices.AddNewBookCategory(bookCategory);

                    return RedirectToAction("BookCategoriesList");

                }

                else
                {
                 
                    return View("AddBookCategory", bookCategory);
                }


            }


        }
    }
