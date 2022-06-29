using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.Interfaces
{
    public interface IBookItemServices
    {
        public IEnumerable<BookItem> GetBookItemsList();
        public IEnumerable<BookItem> GetBookItemsListWithOutCategory();

        public bool AddBookItem(BookItem bookItem);

        public bool EditBookItemData(BookItem item);
        public bool DeleteBookItem(int id);

        public BookItem GetBookItemById(int id);
       public IEnumerable<BookItem> GetRelatedBookItemsList(BookItem bookItem);
        public IQueryable<BookItem> GetUpSalesBookItemsList();



    }
}
