using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
            return _context.Tb_BookCategory.Include(b=>b.bookItems);

        }

        public BookCategory GetBookCategoryById(int id)
        {
            return _context.Tb_BookCategory.Where(c => c.bookCategoryId == id).Include(b => b.bookItems).FirstOrDefault();
        }

        public void AddNewBookCategory(BookCategory bookCategory)
        {
            try {
                _context.Tb_BookCategory.Add(bookCategory);
                _context.SaveChanges();

            }catch(Exception ex)
            {
                return;
            }
        }

        public void EditBookCategory(BookCategory bookCategory)
        {
            try
            {
               _context.Entry(bookCategory).State = EntityState.Modified;
               _context.SaveChanges();

            }
            catch(Exception ex)
            {

                return;
            }
        }

        public void DeleteBookCategory(int id)
        {
            try
            {
                var category = _context.Tb_BookCategory.Where(c => c.bookCategoryId == id).FirstOrDefault();
                _context.Tb_BookCategory.Attach(category);
                _context.Remove(category);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                return;
            }
        }
    }
}
