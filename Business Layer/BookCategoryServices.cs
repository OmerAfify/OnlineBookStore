using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;

namespace OnlineBookStore.Business_Layer
{
    public class BookCategoryServices : IBookCategoryServices
    {
        private OnlineBookStoreDbContext _context { get; set; }

        public BookCategoryServices(OnlineBookStoreDbContext context)
        {
            _context = context;
        }
        public IEnumerable<BookCategory> GetBookCategoriesList()
        {
            return _context.Tb_BookCategory;

        }

    }
}
