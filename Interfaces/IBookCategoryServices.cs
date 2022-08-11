using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.Interfaces
{
    public interface IBookCategoryServices
    {
        public IEnumerable<BookCategory> GetBookCategoriesList();
        public BookCategory GetBookCategoryById(int id);
        public void AddNewBookCategory(BookCategory bookCategory);
        public void EditBookCategory(BookCategory bookCategory);
        public void DeleteBookCategory(int id);

    }
}
