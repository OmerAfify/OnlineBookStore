using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;

namespace OnlineBookStore.Business_Layer
{
    public class BookItemServices : IBookItemServices
    {
        private OnlineBookStoreDbContext _context { get; set; }

        public BookItemServices(OnlineBookStoreDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BookItem> GetBookItemsList()
        {

            return _context.Tb_BookItem.Include(m=>m.bookCategory).OrderByDescending(d=>d.creationalDate);

        }

        public IEnumerable<BookItem> GetBookItemsListWithOutCategory()
        {

            return _context.Tb_BookItem.OrderByDescending(d => d.creationalDate);

        }


        public bool AddBookItem(BookItem bookItem)
        {
            try {

                using (var transaction = _context.Database.BeginTransaction()) { 

                     _context.Tb_BookItem.Add(bookItem);
                     _context.SaveChanges();

                    transaction.Commit();
                }

                return true;
                    
               }catch {

                return false;
            }

        }

        public bool EditBookItemData(BookItem item)
        {
            try
            {

                using (var transaction = _context.Database.BeginTransaction())
                {

                    _context.Entry(item).State = EntityState.Modified;

                    _context.SaveChanges();

                    transaction.Commit();
                }

                return true;

            }
            catch
            {

                return false;
            }

        }

        public bool DeleteBookItem (int id)
        {
            try
            {

                var delItem = this.GetBookItemById(id);
                _context.Tb_BookItem.Remove(delItem);  
                _context.SaveChanges();


                return true;

            }
            catch
            {

                return false;
            }
        }

        public BookItem GetBookItemById(int id)
        {
            return _context.Tb_BookItem.Where(i => i.bookItemId == id).Include(c=>c.bookCategory).FirstOrDefault();
        }


        //related is implemented by having same range of price between -20 itemsprice +20 
        public IEnumerable<BookItem> GetRelatedBookItemsList(BookItem bookItem)
        {
            var maxPrice = bookItem.purchasePrice + 20;
            var minPrice = bookItem.purchasePrice - 20;

            var relatedBookItemsList = _context.Tb_BookItem.
                          Where(b =>b.bookItemId !=bookItem.bookItemId && b.purchasePrice > minPrice && b.purchasePrice < maxPrice);
          
            return relatedBookItemsList;

        }

        public IQueryable<BookItem> GetUpSalesBookItemsList()
        {
            var query = from items in _context.Tb_BookItem
                        join discountItems in _context.Tb_Discount
on items.bookItemId equals discountItems.bookItemId
                        where discountItems.discountEndingDate >= DateTime.Now
                        select items;

            return query;

        }

    
    }
}
