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
    }
}
